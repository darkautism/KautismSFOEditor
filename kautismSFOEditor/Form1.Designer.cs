﻿namespace kautismSFOEditor {
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
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AttributeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remotePlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.moveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.installPKGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allowBGMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.pToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.audioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lPCMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dolbyDigitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dTSDigitalSurroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lPCMToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lPCMToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultSFOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.stringEditor = new System.Windows.Forms.TextBox();
            this.integerEditor = new System.Windows.Forms.NumericUpDown();
            this.listViewEx1 = new ListViewEx.ListViewEx();
            this.tab_Tag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.AttributeToolStripMenuItem,
            this.resolutionToolStripMenuItem,
            this.audioToolStripMenuItem,
            this.defaultSFOToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // AttributeToolStripMenuItem
            // 
            resources.ApplyResources(this.AttributeToolStripMenuItem, "AttributeToolStripMenuItem");
            this.AttributeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remotePlayToolStripMenuItem,
            this.moveToolStripMenuItem,
            this.toolStripSeparator1,
            this.installPKGToolStripMenuItem,
            this.allowBGMToolStripMenuItem});
            this.AttributeToolStripMenuItem.Name = "AttributeToolStripMenuItem";
            // 
            // remotePlayToolStripMenuItem
            // 
            resources.ApplyResources(this.remotePlayToolStripMenuItem, "remotePlayToolStripMenuItem");
            this.remotePlayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.remotePlayToolStripMenuItem.Name = "remotePlayToolStripMenuItem";
            // 
            // toolStripComboBox1
            // 
            resources.ApplyResources(this.toolStripComboBox1, "toolStripComboBox1");
            this.toolStripComboBox1.Items.AddRange(new object[] {
            resources.GetString("toolStripComboBox1.Items"),
            resources.GetString("toolStripComboBox1.Items1"),
            resources.GetString("toolStripComboBox1.Items2"),
            resources.GetString("toolStripComboBox1.Items3")});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // moveToolStripMenuItem
            // 
            resources.ApplyResources(this.moveToolStripMenuItem, "moveToolStripMenuItem");
            this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // installPKGToolStripMenuItem
            // 
            resources.ApplyResources(this.installPKGToolStripMenuItem, "installPKGToolStripMenuItem");
            this.installPKGToolStripMenuItem.CheckOnClick = true;
            this.installPKGToolStripMenuItem.Name = "installPKGToolStripMenuItem";
            this.installPKGToolStripMenuItem.CheckedChanged += new System.EventHandler(this.installPKGToolStripMenuItem_CheckedChanged);
            // 
            // allowBGMToolStripMenuItem
            // 
            resources.ApplyResources(this.allowBGMToolStripMenuItem, "allowBGMToolStripMenuItem");
            this.allowBGMToolStripMenuItem.CheckOnClick = true;
            this.allowBGMToolStripMenuItem.Name = "allowBGMToolStripMenuItem";
            this.allowBGMToolStripMenuItem.CheckedChanged += new System.EventHandler(this.allowBGMToolStripMenuItem_CheckedChanged);
            // 
            // resolutionToolStripMenuItem
            // 
            resources.ApplyResources(this.resolutionToolStripMenuItem, "resolutionToolStripMenuItem");
            this.resolutionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.pToolStripMenuItem,
            this.pToolStripMenuItem1});
            this.resolutionToolStripMenuItem.Name = "resolutionToolStripMenuItem";
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.CheckOnClick = true;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Tag = "";
            this.toolStripMenuItem2.CheckedChanged += new System.EventHandler(this.RESOLUTIONMenuItem_CheckedChanged);
            // 
            // toolStripMenuItem3
            // 
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.CheckOnClick = true;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Tag = "";
            this.toolStripMenuItem3.CheckedChanged += new System.EventHandler(this.RESOLUTIONMenuItem_CheckedChanged);
            // 
            // toolStripMenuItem4
            // 
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            this.toolStripMenuItem4.CheckOnClick = true;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Tag = "";
            this.toolStripMenuItem4.CheckedChanged += new System.EventHandler(this.RESOLUTIONMenuItem_CheckedChanged);
            // 
            // toolStripMenuItem5
            // 
            resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
            this.toolStripMenuItem5.CheckOnClick = true;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Tag = "";
            this.toolStripMenuItem5.CheckedChanged += new System.EventHandler(this.RESOLUTIONMenuItem_CheckedChanged);
            // 
            // pToolStripMenuItem
            // 
            resources.ApplyResources(this.pToolStripMenuItem, "pToolStripMenuItem");
            this.pToolStripMenuItem.CheckOnClick = true;
            this.pToolStripMenuItem.Name = "pToolStripMenuItem";
            this.pToolStripMenuItem.Tag = "";
            this.pToolStripMenuItem.CheckedChanged += new System.EventHandler(this.RESOLUTIONMenuItem_CheckedChanged);
            // 
            // pToolStripMenuItem1
            // 
            resources.ApplyResources(this.pToolStripMenuItem1, "pToolStripMenuItem1");
            this.pToolStripMenuItem1.CheckOnClick = true;
            this.pToolStripMenuItem1.Name = "pToolStripMenuItem1";
            this.pToolStripMenuItem1.Tag = "";
            this.pToolStripMenuItem1.CheckedChanged += new System.EventHandler(this.RESOLUTIONMenuItem_CheckedChanged);
            // 
            // audioToolStripMenuItem
            // 
            resources.ApplyResources(this.audioToolStripMenuItem, "audioToolStripMenuItem");
            this.audioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lPCMToolStripMenuItem,
            this.dolbyDigitalToolStripMenuItem,
            this.dTSDigitalSurroundToolStripMenuItem,
            this.lPCMToolStripMenuItem1,
            this.lPCMToolStripMenuItem2});
            this.audioToolStripMenuItem.Name = "audioToolStripMenuItem";
            // 
            // lPCMToolStripMenuItem
            // 
            resources.ApplyResources(this.lPCMToolStripMenuItem, "lPCMToolStripMenuItem");
            this.lPCMToolStripMenuItem.CheckOnClick = true;
            this.lPCMToolStripMenuItem.Name = "lPCMToolStripMenuItem";
            this.lPCMToolStripMenuItem.CheckedChanged += new System.EventHandler(this.SOUNDFORMAT_MenuItem_CheckedChanged);
            // 
            // dolbyDigitalToolStripMenuItem
            // 
            resources.ApplyResources(this.dolbyDigitalToolStripMenuItem, "dolbyDigitalToolStripMenuItem");
            this.dolbyDigitalToolStripMenuItem.CheckOnClick = true;
            this.dolbyDigitalToolStripMenuItem.Name = "dolbyDigitalToolStripMenuItem";
            this.dolbyDigitalToolStripMenuItem.CheckedChanged += new System.EventHandler(this.SOUNDFORMAT_MenuItem_CheckedChanged);
            // 
            // dTSDigitalSurroundToolStripMenuItem
            // 
            resources.ApplyResources(this.dTSDigitalSurroundToolStripMenuItem, "dTSDigitalSurroundToolStripMenuItem");
            this.dTSDigitalSurroundToolStripMenuItem.CheckOnClick = true;
            this.dTSDigitalSurroundToolStripMenuItem.Name = "dTSDigitalSurroundToolStripMenuItem";
            this.dTSDigitalSurroundToolStripMenuItem.CheckedChanged += new System.EventHandler(this.SOUNDFORMAT_MenuItem_CheckedChanged);
            // 
            // lPCMToolStripMenuItem1
            // 
            resources.ApplyResources(this.lPCMToolStripMenuItem1, "lPCMToolStripMenuItem1");
            this.lPCMToolStripMenuItem1.CheckOnClick = true;
            this.lPCMToolStripMenuItem1.Name = "lPCMToolStripMenuItem1";
            this.lPCMToolStripMenuItem1.CheckedChanged += new System.EventHandler(this.SOUNDFORMAT_MenuItem_CheckedChanged);
            // 
            // lPCMToolStripMenuItem2
            // 
            resources.ApplyResources(this.lPCMToolStripMenuItem2, "lPCMToolStripMenuItem2");
            this.lPCMToolStripMenuItem2.CheckOnClick = true;
            this.lPCMToolStripMenuItem2.Name = "lPCMToolStripMenuItem2";
            this.lPCMToolStripMenuItem2.CheckedChanged += new System.EventHandler(this.SOUNDFORMAT_MenuItem_CheckedChanged);
            // 
            // defaultSFOToolStripMenuItem
            // 
            resources.ApplyResources(this.defaultSFOToolStripMenuItem, "defaultSFOToolStripMenuItem");
            this.defaultSFOToolStripMenuItem.Name = "defaultSFOToolStripMenuItem";
            this.defaultSFOToolStripMenuItem.Click += new System.EventHandler(this.defaultSFOToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.AddExtension = false;
            this.openFileDialog1.FileName = "PARAM.SFO";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // stringEditor
            // 
            resources.ApplyResources(this.stringEditor, "stringEditor");
            this.stringEditor.Name = "stringEditor";
            // 
            // integerEditor
            // 
            resources.ApplyResources(this.integerEditor, "integerEditor");
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
            // 
            // listViewEx1
            // 
            resources.ApplyResources(this.listViewEx1, "listViewEx1");
            this.listViewEx1.AllowColumnReorder = true;
            this.listViewEx1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tab_Tag,
            this.tab_Value});
            this.listViewEx1.DoubleClickActivation = false;
            this.listViewEx1.FullRowSelect = true;
            this.listViewEx1.Name = "listViewEx1";
            this.listViewEx1.UseCompatibleStateImageBehavior = false;
            this.listViewEx1.View = System.Windows.Forms.View.Details;
            this.listViewEx1.SubItemClicked += new ListViewEx.SubItemEventHandler(this.listViewEx1_SubItemClicked);
            // 
            // tab_Tag
            // 
            resources.ApplyResources(this.tab_Tag, "tab_Tag");
            // 
            // tab_Value
            // 
            resources.ApplyResources(this.tab_Value, "tab_Value");
            // 
            // linkLabel2
            // 
            resources.ApplyResources(this.linkLabel2, "linkLabel2");
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.TabStop = true;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.integerEditor);
            this.Controls.Add(this.stringEditor);
            this.Controls.Add(this.listViewEx1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
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
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private ListViewEx.ListViewEx listViewEx1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColumnHeader tab_Tag;
        private System.Windows.Forms.ColumnHeader tab_Value;
        private System.Windows.Forms.TextBox stringEditor;
        private System.Windows.Forms.NumericUpDown integerEditor;
        private System.Windows.Forms.ToolStripMenuItem AttributeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remotePlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem moveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem installPKGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allowBGMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resolutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem pToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem audioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lPCMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dolbyDigitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dTSDigitalSurroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lPCMToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lPCMToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem defaultSFOToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

