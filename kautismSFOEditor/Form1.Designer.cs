namespace kautismSFOEditor {
    partial class Form1 {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.開啟ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.儲存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.屬性ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.遙控遊玩設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.moveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.installPKGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.允許背景音樂ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.解析度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.pToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.音效ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lPCMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dolbyDigitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dTSDigitalSurroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lPCMToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lPCMToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.stringEditor = new System.Windows.Forms.TextBox();
            this.integerEditor = new System.Windows.Forms.NumericUpDown();
            this.listViewEx1 = new ListViewEx.ListViewEx();
            this.標籤 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.數值 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sFO預設使用此軟體開啟ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linkLabel1.Location = new System.Drawing.Point(0, 407);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(143, 12);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://darkautism.blogspot.tw/";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開啟ToolStripMenuItem,
            this.儲存ToolStripMenuItem,
            this.屬性ToolStripMenuItem,
            this.解析度ToolStripMenuItem,
            this.音效ToolStripMenuItem,
            this.sFO預設使用此軟體開啟ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(718, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 開啟ToolStripMenuItem
            // 
            this.開啟ToolStripMenuItem.Name = "開啟ToolStripMenuItem";
            this.開啟ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.開啟ToolStripMenuItem.Text = "開啟";
            this.開啟ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.開啟ToolStripMenuItem.Click += new System.EventHandler(this.開啟ToolStripMenuItem_Click);
            // 
            // 儲存ToolStripMenuItem
            // 
            this.儲存ToolStripMenuItem.Enabled = false;
            this.儲存ToolStripMenuItem.Name = "儲存ToolStripMenuItem";
            this.儲存ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.儲存ToolStripMenuItem.Text = "儲存";
            this.儲存ToolStripMenuItem.Click += new System.EventHandler(this.儲存ToolStripMenuItem_Click);
            // 
            // 屬性ToolStripMenuItem
            // 
            this.屬性ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.遙控遊玩設定ToolStripMenuItem,
            this.moveToolStripMenuItem,
            this.toolStripSeparator1,
            this.installPKGToolStripMenuItem,
            this.允許背景音樂ToolStripMenuItem});
            this.屬性ToolStripMenuItem.Enabled = false;
            this.屬性ToolStripMenuItem.Name = "屬性ToolStripMenuItem";
            this.屬性ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.屬性ToolStripMenuItem.Text = "屬性";
            // 
            // 遙控遊玩設定ToolStripMenuItem
            // 
            this.遙控遊玩設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.遙控遊玩設定ToolStripMenuItem.Name = "遙控遊玩設定ToolStripMenuItem";
            this.遙控遊玩設定ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.遙控遊玩設定ToolStripMenuItem.Text = "遙控遊玩設定";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "不支持",
            "M4V/ATRAC",
            "AVC/AAC",
            "480p AVC"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 24);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // moveToolStripMenuItem
            // 
            this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
            this.moveToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.moveToolStripMenuItem.Text = "Move";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // installPKGToolStripMenuItem
            // 
            this.installPKGToolStripMenuItem.CheckOnClick = true;
            this.installPKGToolStripMenuItem.Name = "installPKGToolStripMenuItem";
            this.installPKGToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.installPKGToolStripMenuItem.Text = "Install PKG";
            this.installPKGToolStripMenuItem.CheckedChanged += new System.EventHandler(this.installPKGToolStripMenuItem_CheckedChanged);
            // 
            // 允許背景音樂ToolStripMenuItem
            // 
            this.允許背景音樂ToolStripMenuItem.CheckOnClick = true;
            this.允許背景音樂ToolStripMenuItem.Name = "允許背景音樂ToolStripMenuItem";
            this.允許背景音樂ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.允許背景音樂ToolStripMenuItem.Text = "允許背景音樂";
            this.允許背景音樂ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.允許背景音樂ToolStripMenuItem_CheckedChanged);
            // 
            // 解析度ToolStripMenuItem
            // 
            this.解析度ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.pToolStripMenuItem,
            this.pToolStripMenuItem1});
            this.解析度ToolStripMenuItem.Enabled = false;
            this.解析度ToolStripMenuItem.Name = "解析度ToolStripMenuItem";
            this.解析度ToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.解析度ToolStripMenuItem.Text = "解析度";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.CheckOnClick = true;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem2.Tag = "";
            this.toolStripMenuItem2.Text = "480i";
            this.toolStripMenuItem2.CheckedChanged += new System.EventHandler(this.RESOLUTIONMenuItem_CheckedChanged);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.CheckOnClick = true;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem3.Tag = "";
            this.toolStripMenuItem3.Text = "480p";
            this.toolStripMenuItem3.CheckedChanged += new System.EventHandler(this.RESOLUTIONMenuItem_CheckedChanged);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.CheckOnClick = true;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem4.Tag = "";
            this.toolStripMenuItem4.Text = "576i";
            this.toolStripMenuItem4.CheckedChanged += new System.EventHandler(this.RESOLUTIONMenuItem_CheckedChanged);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.CheckOnClick = true;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem5.Tag = "";
            this.toolStripMenuItem5.Text = "576p";
            this.toolStripMenuItem5.CheckedChanged += new System.EventHandler(this.RESOLUTIONMenuItem_CheckedChanged);
            // 
            // pToolStripMenuItem
            // 
            this.pToolStripMenuItem.CheckOnClick = true;
            this.pToolStripMenuItem.Name = "pToolStripMenuItem";
            this.pToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.pToolStripMenuItem.Tag = "";
            this.pToolStripMenuItem.Text = "720p";
            this.pToolStripMenuItem.CheckedChanged += new System.EventHandler(this.RESOLUTIONMenuItem_CheckedChanged);
            // 
            // pToolStripMenuItem1
            // 
            this.pToolStripMenuItem1.CheckOnClick = true;
            this.pToolStripMenuItem1.Name = "pToolStripMenuItem1";
            this.pToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.pToolStripMenuItem1.Tag = "";
            this.pToolStripMenuItem1.Text = "1080p";
            this.pToolStripMenuItem1.CheckedChanged += new System.EventHandler(this.RESOLUTIONMenuItem_CheckedChanged);
            // 
            // 音效ToolStripMenuItem
            // 
            this.音效ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lPCMToolStripMenuItem,
            this.dolbyDigitalToolStripMenuItem,
            this.dTSDigitalSurroundToolStripMenuItem,
            this.lPCMToolStripMenuItem1,
            this.lPCMToolStripMenuItem2});
            this.音效ToolStripMenuItem.Enabled = false;
            this.音效ToolStripMenuItem.Name = "音效ToolStripMenuItem";
            this.音效ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.音效ToolStripMenuItem.Text = "音效";
            // 
            // lPCMToolStripMenuItem
            // 
            this.lPCMToolStripMenuItem.CheckOnClick = true;
            this.lPCMToolStripMenuItem.Name = "lPCMToolStripMenuItem";
            this.lPCMToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.lPCMToolStripMenuItem.Text = "2 LPCM";
            this.lPCMToolStripMenuItem.CheckedChanged += new System.EventHandler(this.SOUNDFORMAT_MenuItem_CheckedChanged);
            // 
            // dolbyDigitalToolStripMenuItem
            // 
            this.dolbyDigitalToolStripMenuItem.CheckOnClick = true;
            this.dolbyDigitalToolStripMenuItem.Name = "dolbyDigitalToolStripMenuItem";
            this.dolbyDigitalToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.dolbyDigitalToolStripMenuItem.Text = "5.1 Dolby Digital";
            this.dolbyDigitalToolStripMenuItem.CheckedChanged += new System.EventHandler(this.SOUNDFORMAT_MenuItem_CheckedChanged);
            // 
            // dTSDigitalSurroundToolStripMenuItem
            // 
            this.dTSDigitalSurroundToolStripMenuItem.CheckOnClick = true;
            this.dTSDigitalSurroundToolStripMenuItem.Name = "dTSDigitalSurroundToolStripMenuItem";
            this.dTSDigitalSurroundToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.dTSDigitalSurroundToolStripMenuItem.Text = "DTS Digital Surround";
            this.dTSDigitalSurroundToolStripMenuItem.CheckedChanged += new System.EventHandler(this.SOUNDFORMAT_MenuItem_CheckedChanged);
            // 
            // lPCMToolStripMenuItem1
            // 
            this.lPCMToolStripMenuItem1.CheckOnClick = true;
            this.lPCMToolStripMenuItem1.Name = "lPCMToolStripMenuItem1";
            this.lPCMToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.lPCMToolStripMenuItem1.Text = "5.1 LPCM";
            this.lPCMToolStripMenuItem1.CheckedChanged += new System.EventHandler(this.SOUNDFORMAT_MenuItem_CheckedChanged);
            // 
            // lPCMToolStripMenuItem2
            // 
            this.lPCMToolStripMenuItem2.CheckOnClick = true;
            this.lPCMToolStripMenuItem2.Name = "lPCMToolStripMenuItem2";
            this.lPCMToolStripMenuItem2.Size = new System.Drawing.Size(194, 22);
            this.lPCMToolStripMenuItem2.Text = "7.1 LPCM";
            this.lPCMToolStripMenuItem2.CheckedChanged += new System.EventHandler(this.SOUNDFORMAT_MenuItem_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.AddExtension = false;
            this.openFileDialog1.FileName = "PARAM.SFO";
            this.openFileDialog1.Filter = "SFO檔案|*.sfo|所有檔案|*.*";
            // 
            // stringEditor
            // 
            this.stringEditor.Location = new System.Drawing.Point(399, 27);
            this.stringEditor.Name = "stringEditor";
            this.stringEditor.Size = new System.Drawing.Size(100, 22);
            this.stringEditor.TabIndex = 4;
            this.stringEditor.Visible = false;
            // 
            // integerEditor
            // 
            this.integerEditor.Location = new System.Drawing.Point(516, 27);
            this.integerEditor.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.integerEditor.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.integerEditor.Name = "integerEditor";
            this.integerEditor.Size = new System.Drawing.Size(120, 22);
            this.integerEditor.TabIndex = 5;
            this.integerEditor.Visible = false;
            // 
            // listViewEx1
            // 
            this.listViewEx1.AllowColumnReorder = true;
            this.listViewEx1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.標籤,
            this.數值});
            this.listViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewEx1.DoubleClickActivation = false;
            this.listViewEx1.FullRowSelect = true;
            this.listViewEx1.Location = new System.Drawing.Point(0, 24);
            this.listViewEx1.Name = "listViewEx1";
            this.listViewEx1.Size = new System.Drawing.Size(718, 383);
            this.listViewEx1.TabIndex = 3;
            this.listViewEx1.UseCompatibleStateImageBehavior = false;
            this.listViewEx1.View = System.Windows.Forms.View.Details;
            this.listViewEx1.SubItemClicked += new ListViewEx.SubItemEventHandler(this.listViewEx1_SubItemClicked);
            // 
            // 標籤
            // 
            this.標籤.Text = "標籤";
            this.標籤.Width = 161;
            // 
            // 數值
            // 
            this.數值.Text = "數值";
            this.數值.Width = 498;
            // 
            // sFO預設使用此軟體開啟ToolStripMenuItem
            // 
            this.sFO預設使用此軟體開啟ToolStripMenuItem.Name = "sFO預設使用此軟體開啟ToolStripMenuItem";
            this.sFO預設使用此軟體開啟ToolStripMenuItem.Size = new System.Drawing.Size(151, 20);
            this.sFO預設使用此軟體開啟ToolStripMenuItem.Text = "SFO預設使用此軟體開啟";
            this.sFO預設使用此軟體開啟ToolStripMenuItem.Click += new System.EventHandler(this.sFO預設使用此軟體開啟ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 419);
            this.Controls.Add(this.integerEditor);
            this.Controls.Add(this.stringEditor);
            this.Controls.Add(this.listViewEx1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "kautismSFOEditor";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerEditor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 開啟ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 儲存ToolStripMenuItem;
        private ListViewEx.ListViewEx listViewEx1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColumnHeader 標籤;
        private System.Windows.Forms.ColumnHeader 數值;
        private System.Windows.Forms.TextBox stringEditor;
        private System.Windows.Forms.NumericUpDown integerEditor;
        private System.Windows.Forms.ToolStripMenuItem 屬性ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 遙控遊玩設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem moveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem installPKGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 允許背景音樂ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 解析度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem pToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 音效ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lPCMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dolbyDigitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dTSDigitalSurroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lPCMToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lPCMToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sFO預設使用此軟體開啟ToolStripMenuItem;
    }
}

