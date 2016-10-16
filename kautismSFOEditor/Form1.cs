using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace kautismSFOEditor {
    public partial class Form1 : Form {
        SFOParser m_sfo;
        const int PSP1 = 1;
        const int PSP2 = 5;
        const int PSP3 = 0x85;
        const int MOVE_SUPPORT = 0x800000;
        const int MOVE_CONTROLLER = 0x100;
        const int MOVE_NATIVE_CONTROLLER = 0x200;
        const int MOVE_PLAYSTATION_EYE = 0x400;
        const int MOVE_CALIBRATION = 0x800;
        const int STEREOSCOPIC_3D_WARNING = 0x1000;
        const int BACKGROUND_MUSIC_IN_GAME = 0x20;
        const int INSTALL_PKG = 0x20000;
        const int SUPPORT_GAME_PURCHASE = 0x20000;
        const int RESOLUTION_480I = 0x1;
        const int RESOLUTION_480P = 0x10;
        const int RESOLUTION_576I = 0x2;
        const int RESOLUTION_576P = 0x20;
        const int RESOLUTION_720P = 0x4;
        const int RESOLUTION_1080P = 0x8;
        const int SOUND_FORMATE_2LP = 1;
        const int SOUND_FORMATE_51DD = 0x100;
        const int SOUND_FORMATE_DTS = 0x200;
        const int SOUND_FORMATE_51LP = 0x4;
        const int SOUND_FORMATE_71LP = 0x10;

        ListViewItem m_attribute_lvi;
        ListViewItem m_resolutin_lvi;
        ListViewItem m_sound_formate_lvi;


        public Form1(string[] args) {
            InitializeComponent();
            toolStripMenuItem2.Tag = RESOLUTION_480I;
            toolStripMenuItem3.Tag = RESOLUTION_480P;
            toolStripMenuItem4.Tag = RESOLUTION_576I;
            toolStripMenuItem5.Tag = RESOLUTION_576P;
            pToolStripMenuItem.Tag = RESOLUTION_720P;
            pToolStripMenuItem1.Tag = RESOLUTION_1080P;

            lPCMToolStripMenuItem.Tag = SOUND_FORMATE_2LP;
            lPCMToolStripMenuItem1.Tag = SOUND_FORMATE_51LP;
            lPCMToolStripMenuItem2.Tag = SOUND_FORMATE_71LP;
            dolbyDigitalToolStripMenuItem.Tag = SOUND_FORMATE_51DD;
            dTSDigitalSurroundToolStripMenuItem.Tag = SOUND_FORMATE_DTS;

            if (args.Length > 0)
                OpenFile(args[0]);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start(linkLabel1.Text.ToString());
        }

        private void 開啟ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                OpenFile(openFileDialog1.FileName);
            }
        }

        private void readSFOToListView(SFOParser sfo, ListView lv) {
            lv.Items.Clear();
            屬性ToolStripMenuItem.Enabled = false;
            解析度ToolStripMenuItem.Enabled = false;
            音效ToolStripMenuItem.Enabled = false;
            m_attribute_lvi = null;
            m_sound_formate_lvi = null;
            m_resolutin_lvi = null;
            for (int i = 0; i < sfo.Length; i++) {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = sfo.getKey(i);
                lvi.Tag = i;
                switch (sfo.getType(i)) {
                    case 0:
                        // lvi.SubItems.Add(BitConverter.ToString((byte[])sfo.getValue(i), 16));
                        lvi.SubItems.Add(Encoding.UTF8.GetString((byte[])sfo.getValue(i)));
                        break;
                    case 2:
                        lvi.SubItems.Add((string)sfo.getValue(i));
                        break;
                    case 4:
                        lvi.SubItems.Add(sfo.getValue(i) + "");
                        break;
                    default:
                        lvi.SubItems.Add("(unknow *NOT BE SAVED*) " + BitConverter.ToString((byte[])sfo.getValue(i), 16));
                        break;
                }

                if (sfo.getKey(i).Equals("ATTRIBUTE")) {
                    m_attribute_lvi = lvi;
                    屬性ToolStripMenuItem.Enabled = true;
                    int attribute = (int)sfo.getValue(i);
                    if ((attribute & PSP3) == PSP3) {
                        toolStripComboBox1.SelectedIndex = 3;
                    } else if ((attribute & PSP2) == PSP2) {
                        toolStripComboBox1.SelectedIndex = 2;
                    } else if ((attribute & PSP1) == PSP1) {
                        toolStripComboBox1.SelectedIndex = 1;
                    } else {
                        toolStripComboBox1.SelectedIndex = 0;
                    }
                }

                if (sfo.getKey(i).Equals("RESOLUTION")) {
                    m_resolutin_lvi = lvi;
                    解析度ToolStripMenuItem.Enabled = true;
                    int res = (int)sfo.getValue(i);
                    SetResolution(res);
                }
                if (sfo.getKey(i).Equals("SOUND_FORMAT")) {
                    m_sound_formate_lvi = lvi;
                    音效ToolStripMenuItem.Enabled = true;
                    int snd = (int)sfo.getValue(i);
                    SetSountFormat(snd);
                }
                lv.Items.Add(lvi);
            }
        }

        private void SetResolution(int res) {
            toolStripMenuItem2.CheckedChanged -= RESOLUTIONMenuItem_CheckedChanged;
            toolStripMenuItem3.CheckedChanged -= RESOLUTIONMenuItem_CheckedChanged;
            toolStripMenuItem4.CheckedChanged -= RESOLUTIONMenuItem_CheckedChanged;
            toolStripMenuItem5.CheckedChanged -= RESOLUTIONMenuItem_CheckedChanged;
            pToolStripMenuItem.CheckedChanged -= RESOLUTIONMenuItem_CheckedChanged;
            pToolStripMenuItem1.CheckedChanged -= RESOLUTIONMenuItem_CheckedChanged;
            toolStripMenuItem2.Checked = ((res & RESOLUTION_480I) != 0);
            toolStripMenuItem3.Checked = ((res & RESOLUTION_480P) != 0);
            toolStripMenuItem4.Checked = ((res & RESOLUTION_576I) != 0);
            toolStripMenuItem5.Checked = ((res & RESOLUTION_576P) != 0);
            pToolStripMenuItem.Checked = ((res & RESOLUTION_720P) != 0);
            pToolStripMenuItem1.Checked = ((res & RESOLUTION_1080P) != 0);
            toolStripMenuItem2.CheckedChanged += RESOLUTIONMenuItem_CheckedChanged;
            toolStripMenuItem3.CheckedChanged += RESOLUTIONMenuItem_CheckedChanged;
            toolStripMenuItem4.CheckedChanged += RESOLUTIONMenuItem_CheckedChanged;
            toolStripMenuItem5.CheckedChanged += RESOLUTIONMenuItem_CheckedChanged;
            pToolStripMenuItem.CheckedChanged += RESOLUTIONMenuItem_CheckedChanged;
            pToolStripMenuItem1.CheckedChanged += RESOLUTIONMenuItem_CheckedChanged;
        }

        private void SetSountFormat(int snd) {

            lPCMToolStripMenuItem.CheckedChanged -= SOUNDFORMAT_MenuItem_CheckedChanged;
            lPCMToolStripMenuItem1.CheckedChanged -= SOUNDFORMAT_MenuItem_CheckedChanged;
            lPCMToolStripMenuItem2.CheckedChanged -= SOUNDFORMAT_MenuItem_CheckedChanged;
            dolbyDigitalToolStripMenuItem.CheckedChanged -= SOUNDFORMAT_MenuItem_CheckedChanged;
            dTSDigitalSurroundToolStripMenuItem.CheckedChanged -= SOUNDFORMAT_MenuItem_CheckedChanged;

            lPCMToolStripMenuItem.Checked = ((snd & SOUND_FORMATE_2LP) != 0);
            lPCMToolStripMenuItem1.Checked = ((snd & SOUND_FORMATE_51LP) != 0);
            lPCMToolStripMenuItem2.Checked = ((snd & SOUND_FORMATE_71LP) != 0);
            dolbyDigitalToolStripMenuItem.Checked = ((snd & SOUND_FORMATE_51DD) != 0);
            dTSDigitalSurroundToolStripMenuItem.Checked = ((snd & SOUND_FORMATE_DTS) != 0);

            lPCMToolStripMenuItem.CheckedChanged += SOUNDFORMAT_MenuItem_CheckedChanged;
            lPCMToolStripMenuItem1.CheckedChanged += SOUNDFORMAT_MenuItem_CheckedChanged;
            lPCMToolStripMenuItem2.CheckedChanged += SOUNDFORMAT_MenuItem_CheckedChanged;
            dolbyDigitalToolStripMenuItem.CheckedChanged += SOUNDFORMAT_MenuItem_CheckedChanged;
            dTSDigitalSurroundToolStripMenuItem.CheckedChanged += SOUNDFORMAT_MenuItem_CheckedChanged;
        }

        private void 儲存ToolStripMenuItem_Click(object sender, EventArgs e) {
            foreach (ListViewItem lvi in listViewEx1.Items) {
                if (m_sfo.getType((int)lvi.Tag) == (byte)SFOParser.SFOType.String && lvi.SubItems[1].Text[lvi.SubItems[1].Text.Length-1] != '\0' ) {
                    lvi.SubItems[1].Text += '\0';
                }
                m_sfo.setValue((int)lvi.Tag, lvi.SubItems[1].Text);
            }
            m_sfo.saveSFO();
            MessageBox.Show("存檔完成");
        }


        private void listViewEx1_SubItemClicked(object sender, ListViewEx.SubItemEventArgs e) {
            if (e.SubItem == 1) {
                int line = (int)e.Item.Tag;
                switch (m_sfo.getType(line)) {
                    case 0:
                        listViewEx1.StartEditing(stringEditor, e.Item, e.SubItem);
                        break;
                    case 2:
                        listViewEx1.StartEditing(stringEditor, e.Item, e.SubItem);
                        break;
                    case 4:
                        listViewEx1.StartEditing(integerEditor, e.Item, e.SubItem);
                        break;
                    default:
                        listViewEx1.StartEditing(stringEditor, e.Item, e.SubItem);
                        break;
                }
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (m_attribute_lvi != null) {
                int attr = int.Parse(m_attribute_lvi.SubItems[1].Text);
                attr -= (attr & PSP3);
                switch (toolStripComboBox1.SelectedIndex) {
                    case 0:
                        m_attribute_lvi.SubItems[1].Text = attr + "";
                        break;
                    case 1:
                        m_attribute_lvi.SubItems[1].Text = (attr | PSP1) + "";
                        break;
                    case 2:
                        m_attribute_lvi.SubItems[1].Text = (attr | PSP2) + "";
                        break;
                    case 3:
                        m_attribute_lvi.SubItems[1].Text = (attr | PSP3) + "";
                        break;
                }
            }
        }

        private void installPKGToolStripMenuItem_CheckedChanged(object sender, EventArgs e) {
            if (m_attribute_lvi != null) {
                int attr = int.Parse(m_attribute_lvi.SubItems[1].Text);
                attr -= (attr & INSTALL_PKG);
                if (installPKGToolStripMenuItem.Checked) {
                    attr |= INSTALL_PKG;
                }
                m_attribute_lvi.SubItems[1].Text = attr + "";
            }
        }

        private void 允許背景音樂ToolStripMenuItem_CheckedChanged(object sender, EventArgs e) {
            if (m_attribute_lvi != null) {
                int attr = int.Parse(m_attribute_lvi.SubItems[1].Text);
                attr -= (attr & BACKGROUND_MUSIC_IN_GAME);
                if (允許背景音樂ToolStripMenuItem.Checked) {
                    attr |= BACKGROUND_MUSIC_IN_GAME;
                }
                m_attribute_lvi.SubItems[1].Text = attr + "";
            }
        }

        private void RESOLUTIONMenuItem_CheckedChanged(object sender, EventArgs e) {
            if (m_resolutin_lvi != null) {
                ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
                int res = int.Parse(m_resolutin_lvi.SubItems[1].Text);
                res -= (res & (int)tsmi.Tag);
                if (tsmi.Checked) {
                    res |= (int)tsmi.Tag;
                }
                m_resolutin_lvi.SubItems[1].Text = res + "";
            }
        }

        private void SOUNDFORMAT_MenuItem_CheckedChanged(object sender, EventArgs e) {
            if (m_resolutin_lvi != null) {
                ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
                int res = int.Parse(m_sound_formate_lvi.SubItems[1].Text);
                res -= (res & (int)tsmi.Tag);
                if (tsmi.Checked) {
                    res |= (int)tsmi.Tag;
                }
                m_sound_formate_lvi.SubItems[1].Text = res + "";
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                e.Effect = DragDropEffects.All;
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e) {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            OpenFile(files[0]);
        }

        private void OpenFile(string filename) {
            try {
                m_sfo = new SFOParser(filename);
                readSFOToListView(m_sfo, listViewEx1);
                儲存ToolStripMenuItem.Enabled = true;
            } catch (Exception e) {
                MessageBox.Show(e.Message);
            }
        }

        private void sFO預設使用此軟體開啟ToolStripMenuItem_Click(object sender, EventArgs e) {
            String Extension = ".SFO";//副檔名名稱
            String Extension_Icopath = @"\ico\sfo.ico";//ICO的路徑
            RegistryKey key = Registry.ClassesRoot.OpenSubKey(Extension);
            Registry.ClassesRoot.CreateSubKey(Extension).SetValue("", Extension);
            Registry.ClassesRoot.CreateSubKey(Extension + "\\DefaultIcon").SetValue("", System.Windows.Forms.Application.StartupPath + Extension_Icopath);
            Registry.ClassesRoot.CreateSubKey(Extension + "\\shell\\open\\command").SetValue("", Application.ExecutablePath + " %1", RegistryValueKind.ExpandString);
            MessageBox.Show("設定完成");
        }

    }
}
