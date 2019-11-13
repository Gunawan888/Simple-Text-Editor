using System.Drawing;
namespace TextEditor
{
    partial class TextEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.davidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formattingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultTxt = new System.Windows.Forms.RichTextBox();
            this.toolwelcomeLbl = new System.Windows.Forms.ToolStripLabel();
            this.leftToolStrip = new System.Windows.Forms.ToolStrip();
            this.leftCutBtn = new System.Windows.Forms.ToolStripButton();
            this.leftCopyBtn = new System.Windows.Forms.ToolStripButton();
            this.leftPasteBtn = new System.Windows.Forms.ToolStripButton();
            this.topNewBtn = new System.Windows.Forms.ToolStripButton();
            this.topOpenBtn = new System.Windows.Forms.ToolStripButton();
            this.topSaveBtn = new System.Windows.Forms.ToolStripButton();
            this.topSaveasBtn = new System.Windows.Forms.ToolStripButton();
            this.topBoldBtn = new System.Windows.Forms.ToolStripButton();
            this.topItalicBtn = new System.Windows.Forms.ToolStripButton();
            this.topUnderlineBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fontSizeLbl = new System.Windows.Forms.ToolStripLabel();
            this.fontSizeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.fontFamilyLbl = new System.Windows.Forms.ToolStripLabel();
            this.fontFamilyComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.topToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.topHelpBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.welcomeLbl = new System.Windows.Forms.ToolStripLabel();
            this.ViewOnlyLabel = new System.Windows.Forms.Label();
            this.filenameLbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.leftToolStrip.SuspendLayout();
            this.topToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.davidToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(607, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // davidToolStripMenuItem
            // 
            this.davidToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.davidToolStripMenuItem.Name = "davidToolStripMenuItem";
            this.davidToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.davidToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripMenuItem.Image")));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.Image")));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.formattingToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // formattingToolStripMenuItem
            // 
            this.formattingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldToolStripMenuItem,
            this.italicToolStripMenuItem,
            this.underlineToolStripMenuItem});
            this.formattingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("formattingToolStripMenuItem.Image")));
            this.formattingToolStripMenuItem.Name = "formattingToolStripMenuItem";
            this.formattingToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.formattingToolStripMenuItem.Text = "Formatting";
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("boldToolStripMenuItem.Image")));
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            this.boldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.boldToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.boldToolStripMenuItem.Text = "Bold";
            this.boldToolStripMenuItem.Click += new System.EventHandler(this.boldToolStripMenuItem_Click);
            // 
            // italicToolStripMenuItem
            // 
            this.italicToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("italicToolStripMenuItem.Image")));
            this.italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            this.italicToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.italicToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.italicToolStripMenuItem.Text = "Italic";
            this.italicToolStripMenuItem.Click += new System.EventHandler(this.italicToolStripMenuItem_Click);
            // 
            // underlineToolStripMenuItem
            // 
            this.underlineToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("underlineToolStripMenuItem.Image")));
            this.underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
            this.underlineToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.underlineToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.underlineToolStripMenuItem.Text = "Underline";
            this.underlineToolStripMenuItem.Click += new System.EventHandler(this.underlineToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // resultTxt
            // 
            this.resultTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultTxt.Location = new System.Drawing.Point(33, 55);
            this.resultTxt.Name = "resultTxt";
            this.resultTxt.Size = new System.Drawing.Size(566, 272);
            this.resultTxt.TabIndex = 1;
            this.resultTxt.Text = "";
            // 
            // toolwelcomeLbl
            // 
            this.toolwelcomeLbl.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolwelcomeLbl.Name = "toolwelcomeLbl";
            this.toolwelcomeLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolwelcomeLbl.Size = new System.Drawing.Size(0, 28);
            // 
            // leftToolStrip
            // 
            this.leftToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.leftToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.leftToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftCutBtn,
            this.leftCopyBtn,
            this.leftPasteBtn});
            this.leftToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.leftToolStrip.Location = new System.Drawing.Point(0, 55);
            this.leftToolStrip.Name = "leftToolStrip";
            this.leftToolStrip.Size = new System.Drawing.Size(29, 104);
            this.leftToolStrip.TabIndex = 4;
            this.leftToolStrip.Text = "toolStrip1";
            // 
            // leftCutBtn
            // 
            this.leftCutBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.leftCutBtn.Image = ((System.Drawing.Image)(resources.GetObject("leftCutBtn.Image")));
            this.leftCutBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.leftCutBtn.Name = "leftCutBtn";
            this.leftCutBtn.Size = new System.Drawing.Size(27, 28);
            this.leftCutBtn.Text = "Cut";
            this.leftCutBtn.Click += new System.EventHandler(this.leftCutBtn_Click);
            // 
            // leftCopyBtn
            // 
            this.leftCopyBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.leftCopyBtn.Image = ((System.Drawing.Image)(resources.GetObject("leftCopyBtn.Image")));
            this.leftCopyBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.leftCopyBtn.Name = "leftCopyBtn";
            this.leftCopyBtn.Size = new System.Drawing.Size(27, 28);
            this.leftCopyBtn.Text = "Copy";
            this.leftCopyBtn.Click += new System.EventHandler(this.leftCopyBtn_Click);
            // 
            // leftPasteBtn
            // 
            this.leftPasteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.leftPasteBtn.Image = ((System.Drawing.Image)(resources.GetObject("leftPasteBtn.Image")));
            this.leftPasteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.leftPasteBtn.Name = "leftPasteBtn";
            this.leftPasteBtn.Size = new System.Drawing.Size(27, 28);
            this.leftPasteBtn.Text = "Paste";
            this.leftPasteBtn.Click += new System.EventHandler(this.leftPasteBtn_Click);
            // 
            // topNewBtn
            // 
            this.topNewBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.topNewBtn.Image = ((System.Drawing.Image)(resources.GetObject("topNewBtn.Image")));
            this.topNewBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.topNewBtn.Name = "topNewBtn";
            this.topNewBtn.Size = new System.Drawing.Size(28, 28);
            this.topNewBtn.Text = "New";
            this.topNewBtn.Click += new System.EventHandler(this.topNewBtn_Click_1);
            // 
            // topOpenBtn
            // 
            this.topOpenBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.topOpenBtn.Image = ((System.Drawing.Image)(resources.GetObject("topOpenBtn.Image")));
            this.topOpenBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.topOpenBtn.Name = "topOpenBtn";
            this.topOpenBtn.Size = new System.Drawing.Size(28, 28);
            this.topOpenBtn.Text = "Open";
            this.topOpenBtn.Click += new System.EventHandler(this.topOpenBtn_Click);
            // 
            // topSaveBtn
            // 
            this.topSaveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.topSaveBtn.Image = ((System.Drawing.Image)(resources.GetObject("topSaveBtn.Image")));
            this.topSaveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.topSaveBtn.Name = "topSaveBtn";
            this.topSaveBtn.Size = new System.Drawing.Size(28, 28);
            this.topSaveBtn.Text = "Save";
            this.topSaveBtn.Click += new System.EventHandler(this.topSaveBtn_Click);
            // 
            // topSaveasBtn
            // 
            this.topSaveasBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.topSaveasBtn.Image = ((System.Drawing.Image)(resources.GetObject("topSaveasBtn.Image")));
            this.topSaveasBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.topSaveasBtn.Name = "topSaveasBtn";
            this.topSaveasBtn.Size = new System.Drawing.Size(28, 28);
            this.topSaveasBtn.Text = "Save As";
            this.topSaveasBtn.Click += new System.EventHandler(this.topSaveasBtn_Click);
            // 
            // topBoldBtn
            // 
            this.topBoldBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.topBoldBtn.Image = ((System.Drawing.Image)(resources.GetObject("topBoldBtn.Image")));
            this.topBoldBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.topBoldBtn.Name = "topBoldBtn";
            this.topBoldBtn.Size = new System.Drawing.Size(28, 28);
            this.topBoldBtn.Text = "Bold";
            this.topBoldBtn.Click += new System.EventHandler(this.topBoldBtn_Click);
            // 
            // topItalicBtn
            // 
            this.topItalicBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.topItalicBtn.Image = ((System.Drawing.Image)(resources.GetObject("topItalicBtn.Image")));
            this.topItalicBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.topItalicBtn.Name = "topItalicBtn";
            this.topItalicBtn.Size = new System.Drawing.Size(28, 28);
            this.topItalicBtn.Text = "Italic";
            this.topItalicBtn.Click += new System.EventHandler(this.topItalicBtn_Click);
            // 
            // topUnderlineBtn
            // 
            this.topUnderlineBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.topUnderlineBtn.Image = ((System.Drawing.Image)(resources.GetObject("topUnderlineBtn.Image")));
            this.topUnderlineBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.topUnderlineBtn.Name = "topUnderlineBtn";
            this.topUnderlineBtn.Size = new System.Drawing.Size(28, 28);
            this.topUnderlineBtn.Text = "Underline";
            this.topUnderlineBtn.Click += new System.EventHandler(this.topUnderlineBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // fontSizeLbl
            // 
            this.fontSizeLbl.Name = "fontSizeLbl";
            this.fontSizeLbl.Size = new System.Drawing.Size(54, 28);
            this.fontSizeLbl.Text = "Font Size";
            // 
            // fontSizeComboBox
            // 
            this.fontSizeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.fontSizeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.fontSizeComboBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "32",
            "48",
            "64",
            "72"});
            this.fontSizeComboBox.Name = "fontSizeComboBox";
            this.fontSizeComboBox.Size = new System.Drawing.Size(121, 31);
            this.fontSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.fontSizeComboBox_SelectedIndexChanged);
            // 
            // fontFamilyLbl
            // 
            this.fontFamilyLbl.Name = "fontFamilyLbl";
            this.fontFamilyLbl.Size = new System.Drawing.Size(69, 28);
            this.fontFamilyLbl.Text = "Font Family";
            // 
            // fontFamilyComboBox
            // 
            this.fontFamilyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.fontFamilyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.fontFamilyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.fontFamilyComboBox.Name = "fontFamilyComboBox";
            this.fontFamilyComboBox.Size = new System.Drawing.Size(82, 31);
            this.fontFamilyComboBox.SelectedIndexChanged += new System.EventHandler(this.fontFamilyComboBox_SelectedIndexChanged);
            // 
            // topToolStrip
            // 
            this.topToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.topToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.topToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.topToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topNewBtn,
            this.topOpenBtn,
            this.topSaveBtn,
            this.topSaveasBtn,
            this.toolStripSeparator1,
            this.topBoldBtn,
            this.topItalicBtn,
            this.topUnderlineBtn,
            this.toolStripSeparator3,
            this.fontSizeLbl,
            this.fontSizeComboBox,
            this.fontFamilyLbl,
            this.fontFamilyComboBox,
            this.topHelpBtn,
            this.toolStripSeparator2,
            this.welcomeLbl});
            this.topToolStrip.Location = new System.Drawing.Point(0, 24);
            this.topToolStrip.Name = "topToolStrip";
            this.topToolStrip.Size = new System.Drawing.Size(656, 31);
            this.topToolStrip.TabIndex = 3;
            this.topToolStrip.Text = "text";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // topHelpBtn
            // 
            this.topHelpBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.topHelpBtn.Image = ((System.Drawing.Image)(resources.GetObject("topHelpBtn.Image")));
            this.topHelpBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.topHelpBtn.Name = "topHelpBtn";
            this.topHelpBtn.Size = new System.Drawing.Size(28, 28);
            this.topHelpBtn.Text = "Help";
            this.topHelpBtn.Click += new System.EventHandler(this.topHelpBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(72, 28);
            this.welcomeLbl.Text = "NAME HERE";
            // 
            // ViewOnlyLabel
            // 
            this.ViewOnlyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewOnlyLabel.AutoSize = true;
            this.ViewOnlyLabel.BackColor = System.Drawing.Color.Yellow;
            this.ViewOnlyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewOnlyLabel.ForeColor = System.Drawing.Color.Black;
            this.ViewOnlyLabel.Location = new System.Drawing.Point(522, 4);
            this.ViewOnlyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ViewOnlyLabel.Name = "ViewOnlyLabel";
            this.ViewOnlyLabel.Size = new System.Drawing.Size(80, 15);
            this.ViewOnlyLabel.TabIndex = 5;
            this.ViewOnlyLabel.Text = "VIEW ONLY";
            this.ViewOnlyLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ViewOnlyLabel.Visible = false;
            // 
            // filenameLbl
            // 
            this.filenameLbl.AutoSize = true;
            this.filenameLbl.BackColor = System.Drawing.Color.Transparent;
            this.filenameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filenameLbl.Location = new System.Drawing.Point(234, 4);
            this.filenameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.filenameLbl.Name = "filenameLbl";
            this.filenameLbl.Size = new System.Drawing.Size(57, 15);
            this.filenameLbl.TabIndex = 6;
            this.filenameLbl.Text = "Doc1.rtf";
            this.filenameLbl.Visible = false;
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(607, 335);
            this.Controls.Add(this.filenameLbl);
            this.Controls.Add(this.ViewOnlyLabel);
            this.Controls.Add(this.leftToolStrip);
            this.Controls.Add(this.topToolStrip);
            this.Controls.Add(this.resultTxt);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TextEditor";
            this.Text = "Text Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.leftToolStrip.ResumeLayout(false);
            this.leftToolStrip.PerformLayout();
            this.topToolStrip.ResumeLayout(false);
            this.topToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem davidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.RichTextBox resultTxt;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolwelcomeLbl;
        private System.Windows.Forms.ToolStrip leftToolStrip;
        private System.Windows.Forms.ToolStripButton leftCutBtn;
        private System.Windows.Forms.ToolStripButton leftCopyBtn;
        private System.Windows.Forms.ToolStripButton leftPasteBtn;
        private System.Windows.Forms.ToolStripButton topNewBtn;
        private System.Windows.Forms.ToolStripButton topOpenBtn;
        private System.Windows.Forms.ToolStripButton topSaveBtn;
        private System.Windows.Forms.ToolStripButton topSaveasBtn;
        private System.Windows.Forms.ToolStripButton topBoldBtn;
        private System.Windows.Forms.ToolStripButton topItalicBtn;
        private System.Windows.Forms.ToolStripButton topUnderlineBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel fontSizeLbl;
        private System.Windows.Forms.ToolStripComboBox fontSizeComboBox;
        private System.Windows.Forms.ToolStripLabel fontFamilyLbl;
        private System.Windows.Forms.ToolStripComboBox fontFamilyComboBox;
        private System.Windows.Forms.ToolStrip topToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel welcomeLbl;
        private System.Windows.Forms.ToolStripButton topHelpBtn;
        private System.Windows.Forms.Label ViewOnlyLabel;
        private System.Windows.Forms.ToolStripMenuItem formattingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underlineToolStripMenuItem;
        private System.Windows.Forms.Label filenameLbl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}