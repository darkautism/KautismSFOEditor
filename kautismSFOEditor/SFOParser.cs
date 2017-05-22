using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

class SFOParser {
    public enum SFOType: byte
    {
        Byte = 0,
        String = 2,
        Interge = 4
    };

    private int alignment(int num, int aliment) {
        int tmp = (int)(num % aliment);
        if (tmp != 0) {
            return num + 4 - tmp;
        } else {
            return num;
        }
    }

    PsfHdr psfHdr;
    PsfSec[] psfSec;
    Encoding encode = Encoding.UTF8;
    SFOPair[] pairs; // 寫入要用
    string filePath;
    public SFOParser(string filePath) {
        FileAttributes attr = File.GetAttributes(filePath);

        //detect whether its a directory or file
        if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
            throw new Exception("不是正確的SFO檔");
        this.filePath = filePath;
        BinaryReader bs = new BinaryReader(new FileStream(filePath, FileMode.Open));
        byte[] tmpbuffer = bs.ReadBytes(Marshal.SizeOf(typeof(PsfHdr)));
        GCHandle handle = GCHandle.Alloc(tmpbuffer, GCHandleType.Pinned);
        psfHdr = (PsfHdr)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(PsfHdr));
        handle.Free();

        if (!Enumerable.SequenceEqual( psfHdr.psf, new char[] {'\0','P', 'S', 'F'})) {
            throw new Exception("不是正確的SFO檔");
        }
#if DEBUG
        Console.WriteLine("{0}個區塊", psfHdr.nsects);
#endif
        psfSec = new PsfSec[psfHdr.nsects];
        for (int i = 0; i < psfHdr.nsects; i++) {
            tmpbuffer = bs.ReadBytes(Marshal.SizeOf(typeof(PsfSec)));
            handle = GCHandle.Alloc(tmpbuffer, GCHandleType.Pinned);
            psfSec[i] = (PsfSec)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(PsfSec));
            handle.Free();
        }
        
        pairs = new SFOPair[psfHdr.nsects];
        for (int i = 0; i < psfHdr.nsects; i++) {
            bs.BaseStream.Position = psfSec[i].label_off + psfHdr.label_ptr;
            tmpbuffer = readByteString(bs);
            pairs[i] = new SFOPair();
            pairs[i].label = encode.GetString(tmpbuffer);
            pairs[i].psfsec = psfSec[i];
            bs.BaseStream.Position = psfSec[i].data_off + psfHdr.data_ptr;
            tmpbuffer = bs.ReadBytes(psfSec[i].datafield_used);
            pairs[i].type = psfSec[i].data_type;
            switch (psfSec[i].data_type) {
                case 0:
                    pairs[i].value = tmpbuffer;
                    break;
                case 2:
                    pairs[i].value = encode.GetString(tmpbuffer);
                    break;
                case 4:
                    pairs[i].value = BitConverter.ToInt32(tmpbuffer, 0);
                    break;
                default:
                    break;
            }
#if DEBUG
            Console.WriteLine("Label:{0}, Type:{1:X}, Value:{2}", pairs[i].label, pairs[i].type, pairs[i].value);
#endif
        }



        bs.Close();
    }

    /// <summary>
    /// save SFO file
    /// </summary>
    public void saveSFO() {
        BinaryWriter bw = new BinaryWriter(new FileStream(filePath, FileMode.Open));
        byte[] tmpBuffer;
        GCHandle handle;
        psfHdr.label_ptr = Marshal.SizeOf(typeof(PsfHdr)) + psfHdr.nsects * Marshal.SizeOf(typeof(PsfSec));
        // write label Field
        bw.BaseStream.Position = psfHdr.label_ptr;
        for (int i = 0; i < psfHdr.nsects; i++) {
            psfSec[i].label_off = (short)(bw.BaseStream.Position - psfHdr.label_ptr);
            int sz_label = pairs[i].label.Length + 1;
            //int sz_label = aliment(pairs[i].label.Length + 1, 4);
            char []charBuffer = new char[sz_label];
            Array.Copy(pairs[i].label.ToCharArray(), charBuffer, pairs[i].label.Length);
            bw.Write(charBuffer);
        }

        // aline to 4byte
        psfHdr.data_ptr = alignment((int)bw.BaseStream.Position, 4);
        while (psfHdr.data_ptr != bw.BaseStream.Position) {
            bw.Write('\0');
        }
        // write data set 
        for (int i = 0, current_offset = 0; i < psfHdr.nsects; i++) {
            psfSec[i].data_off = current_offset;
            bw.BaseStream.Position = psfSec[i].data_off + psfHdr.data_ptr;
            switch (psfSec[i].data_type) {
                case 0:
                    tmpBuffer = (byte[])pairs[i].value;
                    break;
                case 2:
                    tmpBuffer = encode.GetBytes((string)pairs[i].value);
                    break;
                case 4:
                    tmpBuffer = BitConverter.GetBytes((int)pairs[i].value);
                    break;
                default:
                    tmpBuffer = (byte[])pairs[i].value;
                    break;
            }
            psfSec[i].datafield_used = tmpBuffer.Length;
            Console.WriteLine(psfSec[i].datafield_used + " " + encode.GetString(tmpBuffer)  + "\n");
            if (psfSec[i].datafield_size < psfSec[i].datafield_used) {
                // 對齊4byte
                psfSec[i].datafield_size = alignment((int)psfSec[i].datafield_used, 4);
            }

            char []clear_buf = new char[psfSec[i].datafield_size];
            bw.Write(clear_buf);
            bw.BaseStream.Position = psfSec[i].data_off + psfHdr.data_ptr;
            bw.Write(tmpBuffer);
            current_offset += psfSec[i].datafield_size;

        }

        // write psfSec, and get new data_ptr offset
        bw.BaseStream.Position = Marshal.SizeOf(typeof(PsfHdr));
        for (int i = 0; i < psfHdr.nsects; i++) {
            tmpBuffer = new byte[Marshal.SizeOf(typeof(PsfSec))];
            handle = GCHandle.Alloc(tmpBuffer, GCHandleType.Pinned);
            Marshal.StructureToPtr(psfSec[i], handle.AddrOfPinnedObject(), false);
            handle.Free();
            bw.Write(tmpBuffer);
        }
        psfHdr.label_ptr = (int)bw.BaseStream.Position;

        // write psfHdr
        bw.BaseStream.Position = 0;
        tmpBuffer = new byte[Marshal.SizeOf(typeof(PsfHdr))];
        handle = GCHandle.Alloc(tmpBuffer, GCHandleType.Pinned);
        Marshal.StructureToPtr(psfHdr, handle.AddrOfPinnedObject(), false);
        handle.Free();
        bw.Write(tmpBuffer);

        bw.Close();
    }

    /// <summary>
    /// get value from key
    /// </summary>
    /// <param name="key">key (label)</param>
    /// <returns></returns>
    public object getValue(string key) {
        for (int i = 0;  i < pairs.Length; i++) {
            if (pairs[i].label == key) {
                return pairs[i].value;
            }
        }
        return null;
    }

    /// <summary>
    /// get SFO Length
    /// </summary>
    public int Length { get { return psfHdr.nsects; } }

    /// <summary>
    /// get value from index
    /// </summary>
    /// <param name="index">index</param>
    /// <returns></returns>
    public object getValue(int index) {
        return pairs[index].value;
    }
    /// <summary>
    /// get Key from index
    /// </summary>
    /// <param name="index">index</param>
    /// <returns></returns>
    public string getKey(int index) {
        return pairs[index].label;
    }
    /// <summary>
    /// get Type from index
    /// </summary>
    /// <param name="index">index</param>
    /// <returns></returns>
    public byte getType(int index) {
        return pairs[index].type;
    }

    public void setValue(int index, string value) {
        switch (pairs[index].type) {
            case 0:
                pairs[index].value = encode.GetBytes(value);
                break;
            case 2:
                if (value[value.Length - 1] != 0)
                    value += '\0';
                pairs[index].value = value;
                break;
            case 4:
                pairs[index].value = int.Parse(value);
                break;
            default:
                // pairs[index].value = (byte[])pairs[i].value;
                // unknow type and do nothing
                break;
        }
    }

    public void setLabel(int index, string value) {
        //if (value[value.Length - 1] != 0)
        //    value += '\0';
        pairs[index].label = value;
    }


    /// <summary>
    /// a struct of data
    /// </summary>
    private class SFOPair {
        public string label;
        public byte type;
        public object value;
        public PsfSec psfsec;
    }

    private byte[] readByteString(BinaryReader bs) {
        List<byte> array = new List<byte>();
        byte tmp;
        while ((tmp = bs.ReadByte()) != 0) {
            array.Add(tmp);
        }
        return array.ToArray();
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    private struct PsfHdr {

        /// char[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = System.Runtime.InteropServices.UnmanagedType.U1)]
        public char[] psf;

        /// byte[4]
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I1)]
        public byte[] unknow;

        /// int
        public int label_ptr;

        /// int
        public int data_ptr;

        /// int
        public int nsects;
    }

    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 0, Size = 16, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
    private struct PsfSec {

        /// short
        public short label_off;

        /// byte
        public byte unknow;

        /// byte
        public byte data_type;

        /// int
        public int datafield_used;

        /// int
        public int datafield_size;

        /// int
        public int data_off;
    }

}
