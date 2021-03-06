﻿namespace DevOrganizer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gAYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToSystemTrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerOnOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerOnMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerOffMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerIntervalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minutesMenuItem_5 = new System.Windows.Forms.ToolStripMenuItem();
            this.minutesMenuItem_10 = new System.Windows.Forms.ToolStripMenuItem();
            this.minutesMenuItem_15 = new System.Windows.Forms.ToolStripMenuItem();
            this.minutesMenuItem_30 = new System.Windows.Forms.ToolStripMenuItem();
            this.hourMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hoursMenuItem_5 = new System.Windows.Forms.ToolStripMenuItem();
            this.hoursMenuItem_10 = new System.Windows.Forms.ToolStripMenuItem();
            this.hoursMenuItem_15 = new System.Windows.Forms.ToolStripMenuItem();
            this.hoursMenuItem_24 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.addTab = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.addAuthorButton = new System.Windows.Forms.Button();
            this.authorsTextBox = new System.Windows.Forms.TextBox();
            this.authorsListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addTagButton = new System.Windows.Forms.Button();
            this.tagsTextBox = new System.Windows.Forms.TextBox();
            this.tagsListBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FolderOption = new System.Windows.Forms.RadioButton();
            this.FileOption = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.DatabaseTab = new System.Windows.Forms.TabPage();
            this.editFilepathButton = new System.Windows.Forms.Button();
            this.copiedLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.devOrgDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.devOrgDBDataSet = new DevOrganizer.DevOrgDBDataSet();
            this.fileTagsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.fileTagsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showFormToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fileTagsTableAdapter = new DevOrganizer.DevOrgDBDataSetTableAdapters.FileTagsTableAdapter();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.newTagsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.filepathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.addTab.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.DatabaseTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devOrgDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devOrgDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileTagsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileTagsBindingSource1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.newTagsContextMenu.SuspendLayout();
            this.authorsContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gAYToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(956, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // gAYToolStripMenuItem
            // 
            this.gAYToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideToSystemTrayToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gAYToolStripMenuItem.Name = "gAYToolStripMenuItem";
            this.gAYToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.gAYToolStripMenuItem.Text = "File";
            this.gAYToolStripMenuItem.Click += new System.EventHandler(this.gAYToolStripMenuItem_Click);
            // 
            // hideToSystemTrayToolStripMenuItem
            // 
            this.hideToSystemTrayToolStripMenuItem.Name = "hideToSystemTrayToolStripMenuItem";
            this.hideToSystemTrayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hideToSystemTrayToolStripMenuItem.Text = "Hide to System Tray";
            this.hideToSystemTrayToolStripMenuItem.Click += new System.EventHandler(this.hideToSystemTrayToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timerOnOffToolStripMenuItem,
            this.timerIntervalToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // timerOnOffToolStripMenuItem
            // 
            this.timerOnOffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timerOnMenuItem,
            this.timerOffMenuItem});
            this.timerOnOffToolStripMenuItem.Name = "timerOnOffToolStripMenuItem";
            this.timerOnOffToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.timerOnOffToolStripMenuItem.Text = "Update Timer On/Off";
            // 
            // timerOnMenuItem
            // 
            this.timerOnMenuItem.Checked = true;
            this.timerOnMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.timerOnMenuItem.Name = "timerOnMenuItem";
            this.timerOnMenuItem.Size = new System.Drawing.Size(125, 22);
            this.timerOnMenuItem.Text = "Timer On";
            this.timerOnMenuItem.Click += new System.EventHandler(this.timerOnMenuItem_Click);
            // 
            // timerOffMenuItem
            // 
            this.timerOffMenuItem.Name = "timerOffMenuItem";
            this.timerOffMenuItem.Size = new System.Drawing.Size(125, 22);
            this.timerOffMenuItem.Text = "Timer Off";
            this.timerOffMenuItem.Click += new System.EventHandler(this.timerOffMenuItem_Click);
            // 
            // timerIntervalToolStripMenuItem
            // 
            this.timerIntervalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minutesMenuItem_5,
            this.minutesMenuItem_10,
            this.minutesMenuItem_15,
            this.minutesMenuItem_30,
            this.hourMenuItem_1,
            this.hoursMenuItem_5,
            this.hoursMenuItem_10,
            this.hoursMenuItem_15,
            this.hoursMenuItem_24});
            this.timerIntervalToolStripMenuItem.Name = "timerIntervalToolStripMenuItem";
            this.timerIntervalToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.timerIntervalToolStripMenuItem.Text = "Update Timer Interval";
            // 
            // minutesMenuItem_5
            // 
            this.minutesMenuItem_5.Checked = true;
            this.minutesMenuItem_5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.minutesMenuItem_5.Name = "minutesMenuItem_5";
            this.minutesMenuItem_5.Size = new System.Drawing.Size(132, 22);
            this.minutesMenuItem_5.Text = "5 minutes";
            this.minutesMenuItem_5.Click += new System.EventHandler(this.minutesMenuItem_5_Click);
            // 
            // minutesMenuItem_10
            // 
            this.minutesMenuItem_10.Name = "minutesMenuItem_10";
            this.minutesMenuItem_10.Size = new System.Drawing.Size(132, 22);
            this.minutesMenuItem_10.Text = "10 minutes";
            this.minutesMenuItem_10.Click += new System.EventHandler(this.minutesMenuItem_10_Click);
            // 
            // minutesMenuItem_15
            // 
            this.minutesMenuItem_15.Name = "minutesMenuItem_15";
            this.minutesMenuItem_15.Size = new System.Drawing.Size(132, 22);
            this.minutesMenuItem_15.Text = "15 minutes";
            this.minutesMenuItem_15.Click += new System.EventHandler(this.minutesMenuItem_15_Click);
            // 
            // minutesMenuItem_30
            // 
            this.minutesMenuItem_30.Name = "minutesMenuItem_30";
            this.minutesMenuItem_30.Size = new System.Drawing.Size(132, 22);
            this.minutesMenuItem_30.Text = "30 minutes";
            this.minutesMenuItem_30.Click += new System.EventHandler(this.minutesMenuItem_30_Click);
            // 
            // hourMenuItem_1
            // 
            this.hourMenuItem_1.Name = "hourMenuItem_1";
            this.hourMenuItem_1.Size = new System.Drawing.Size(132, 22);
            this.hourMenuItem_1.Text = "1 hour";
            this.hourMenuItem_1.Click += new System.EventHandler(this.hourMenuItem_1_Click);
            // 
            // hoursMenuItem_5
            // 
            this.hoursMenuItem_5.Name = "hoursMenuItem_5";
            this.hoursMenuItem_5.Size = new System.Drawing.Size(132, 22);
            this.hoursMenuItem_5.Text = "5 hours";
            this.hoursMenuItem_5.Click += new System.EventHandler(this.hoursMenuItem_5_Click);
            // 
            // hoursMenuItem_10
            // 
            this.hoursMenuItem_10.Name = "hoursMenuItem_10";
            this.hoursMenuItem_10.Size = new System.Drawing.Size(132, 22);
            this.hoursMenuItem_10.Text = "10 hours";
            this.hoursMenuItem_10.Click += new System.EventHandler(this.hoursMenuItem_10_Click);
            // 
            // hoursMenuItem_15
            // 
            this.hoursMenuItem_15.Name = "hoursMenuItem_15";
            this.hoursMenuItem_15.Size = new System.Drawing.Size(132, 22);
            this.hoursMenuItem_15.Text = "15 hours";
            this.hoursMenuItem_15.Click += new System.EventHandler(this.hoursMenuItem_15_Click);
            // 
            // hoursMenuItem_24
            // 
            this.hoursMenuItem_24.Name = "hoursMenuItem_24";
            this.hoursMenuItem_24.Size = new System.Drawing.Size(132, 22);
            this.hoursMenuItem_24.Text = "24 hours";
            this.hoursMenuItem_24.Click += new System.EventHandler(this.hoursMenuItem_24_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readMeToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // readMeToolStripMenuItem
            // 
            this.readMeToolStripMenuItem.Name = "readMeToolStripMenuItem";
            this.readMeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.readMeToolStripMenuItem.Text = "ReadMe";
            this.readMeToolStripMenuItem.Click += new System.EventHandler(this.readMeToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.addTab);
            this.tabControl1.Controls.Add(this.DatabaseTab);
            this.tabControl1.Location = new System.Drawing.Point(0, 65);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(956, 410);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // addTab
            // 
            this.addTab.Controls.Add(this.groupBox4);
            this.addTab.Controls.Add(this.groupBox2);
            this.addTab.Controls.Add(this.groupBox3);
            this.addTab.Controls.Add(this.browseButton);
            this.addTab.Controls.Add(this.label3);
            this.addTab.Controls.Add(this.pathTextBox);
            this.addTab.Controls.Add(this.groupBox1);
            this.addTab.Controls.Add(this.button1);
            this.addTab.Location = new System.Drawing.Point(4, 23);
            this.addTab.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.addTab.Name = "addTab";
            this.addTab.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.addTab.Size = new System.Drawing.Size(948, 383);
            this.addTab.TabIndex = 0;
            this.addTab.Text = "Add Project";
            this.addTab.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.addAuthorButton);
            this.groupBox4.Controls.Add(this.authorsTextBox);
            this.groupBox4.Controls.Add(this.authorsListBox);
            this.groupBox4.Location = new System.Drawing.Point(636, 84);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(307, 227);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Authors";
            // 
            // addAuthorButton
            // 
            this.addAuthorButton.Location = new System.Drawing.Point(226, 18);
            this.addAuthorButton.Name = "addAuthorButton";
            this.addAuthorButton.Size = new System.Drawing.Size(75, 23);
            this.addAuthorButton.TabIndex = 11;
            this.addAuthorButton.Text = "Add";
            this.addAuthorButton.UseVisualStyleBackColor = true;
            this.addAuthorButton.Click += new System.EventHandler(this.addAuthorButton_Click);
            // 
            // authorsTextBox
            // 
            this.authorsTextBox.Location = new System.Drawing.Point(6, 19);
            this.authorsTextBox.Name = "authorsTextBox";
            this.authorsTextBox.Size = new System.Drawing.Size(214, 20);
            this.authorsTextBox.TabIndex = 10;
            this.authorsTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.authorsTextBox_KeyDown);
            // 
            // authorsListBox
            // 
            this.authorsListBox.FormattingEnabled = true;
            this.authorsListBox.ItemHeight = 14;
            this.authorsListBox.Location = new System.Drawing.Point(6, 49);
            this.authorsListBox.Name = "authorsListBox";
            this.authorsListBox.Size = new System.Drawing.Size(295, 172);
            this.authorsListBox.TabIndex = 9;
            this.authorsListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.authorsListBox_KeyDown);
            this.authorsListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.authorsListBox_MouseDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addTagButton);
            this.groupBox2.Controls.Add(this.tagsTextBox);
            this.groupBox2.Controls.Add(this.tagsListBox);
            this.groupBox2.Location = new System.Drawing.Point(8, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 227);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Tags";
            // 
            // addTagButton
            // 
            this.addTagButton.Location = new System.Drawing.Point(226, 18);
            this.addTagButton.Name = "addTagButton";
            this.addTagButton.Size = new System.Drawing.Size(75, 23);
            this.addTagButton.TabIndex = 11;
            this.addTagButton.Text = "Add";
            this.addTagButton.UseVisualStyleBackColor = true;
            this.addTagButton.Click += new System.EventHandler(this.addTagButton_Click);
            // 
            // tagsTextBox
            // 
            this.tagsTextBox.Location = new System.Drawing.Point(6, 19);
            this.tagsTextBox.Name = "tagsTextBox";
            this.tagsTextBox.Size = new System.Drawing.Size(214, 20);
            this.tagsTextBox.TabIndex = 10;
            this.tagsTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tagsTextBox_KeyDown);
            // 
            // tagsListBox
            // 
            this.tagsListBox.FormattingEnabled = true;
            this.tagsListBox.ItemHeight = 14;
            this.tagsListBox.Location = new System.Drawing.Point(6, 48);
            this.tagsListBox.Name = "tagsListBox";
            this.tagsListBox.Size = new System.Drawing.Size(295, 172);
            this.tagsListBox.TabIndex = 9;
            this.tagsListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tagsListBox_KeyDown);
            this.tagsListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tagsListBox_MouseDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.descriptionTextBox);
            this.groupBox3.Location = new System.Drawing.Point(321, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 227);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(6, 19);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(295, 201);
            this.descriptionTextBox.TabIndex = 10;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(865, 35);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 8;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Path";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(118, 35);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(741, 20);
            this.pathTextBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FolderOption);
            this.groupBox1.Controls.Add(this.FileOption);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 71);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add by: ";
            // 
            // FolderOption
            // 
            this.FolderOption.AutoSize = true;
            this.FolderOption.Location = new System.Drawing.Point(3, 40);
            this.FolderOption.Name = "FolderOption";
            this.FolderOption.Size = new System.Drawing.Size(60, 18);
            this.FolderOption.TabIndex = 1;
            this.FolderOption.Text = "Folder";
            this.FolderOption.UseVisualStyleBackColor = true;
            this.FolderOption.Click += new System.EventHandler(this.FolderOption_Click);
            // 
            // FileOption
            // 
            this.FileOption.AutoSize = true;
            this.FileOption.Checked = true;
            this.FileOption.Location = new System.Drawing.Point(3, 16);
            this.FileOption.Name = "FileOption";
            this.FileOption.Size = new System.Drawing.Size(44, 18);
            this.FileOption.TabIndex = 0;
            this.FileOption.TabStop = true;
            this.FileOption.Text = "File";
            this.FileOption.UseVisualStyleBackColor = true;
            this.FileOption.Click += new System.EventHandler(this.FileOption_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 338);
            this.button1.MinimumSize = new System.Drawing.Size(113, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Project";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddProjectButton_OnClick);
            // 
            // DatabaseTab
            // 
            this.DatabaseTab.Controls.Add(this.editFilepathButton);
            this.DatabaseTab.Controls.Add(this.copiedLabel);
            this.DatabaseTab.Controls.Add(this.updateButton);
            this.DatabaseTab.Controls.Add(this.button3);
            this.DatabaseTab.Controls.Add(this.deleteButton);
            this.DatabaseTab.Controls.Add(this.loadButton);
            this.DatabaseTab.Controls.Add(this.dataGridView1);
            this.DatabaseTab.Location = new System.Drawing.Point(4, 23);
            this.DatabaseTab.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.DatabaseTab.Name = "DatabaseTab";
            this.DatabaseTab.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.DatabaseTab.Size = new System.Drawing.Size(948, 383);
            this.DatabaseTab.TabIndex = 1;
            this.DatabaseTab.Text = "Database View";
            this.DatabaseTab.UseVisualStyleBackColor = true;
            // 
            // editFilepathButton
            // 
            this.editFilepathButton.Location = new System.Drawing.Point(11, 146);
            this.editFilepathButton.Name = "editFilepathButton";
            this.editFilepathButton.Size = new System.Drawing.Size(75, 38);
            this.editFilepathButton.TabIndex = 8;
            this.editFilepathButton.Text = "Edit Filepath";
            this.editFilepathButton.UseVisualStyleBackColor = true;
            this.editFilepathButton.Click += new System.EventHandler(this.editFilepathButton_Click);
            // 
            // copiedLabel
            // 
            this.copiedLabel.AutoSize = true;
            this.copiedLabel.Location = new System.Drawing.Point(22, 234);
            this.copiedLabel.Name = "copiedLabel";
            this.copiedLabel.Size = new System.Drawing.Size(46, 14);
            this.copiedLabel.TabIndex = 7;
            this.copiedLabel.Text = "Copied";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(11, 53);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 58);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Check Data Validity";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 41);
            this.button3.TabIndex = 5;
            this.button3.Text = "Copy to Clipboard";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.copyClipboard_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(11, 117);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(11, 7);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 40);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "Reload View";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filepathDataGridViewTextBoxColumn,
            this.tagsDataGridViewTextBoxColumn,
            this.author,
            this.description});
            this.dataGridView1.DataMember = "FileTags";
            this.dataGridView1.DataSource = this.devOrgDBDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(92, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(848, 375);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.onFilepathDoubleClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // devOrgDBDataSetBindingSource
            // 
            this.devOrgDBDataSetBindingSource.DataSource = this.devOrgDBDataSet;
            this.devOrgDBDataSetBindingSource.Position = 0;
            // 
            // devOrgDBDataSet
            // 
            this.devOrgDBDataSet.DataSetName = "DevOrgDBDataSet";
            this.devOrgDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fileTagsBindingSource
            // 
            this.fileTagsBindingSource.DataMember = "FileTags";
            this.fileTagsBindingSource.DataSource = this.devOrgDBDataSetBindingSource;
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.Location = new System.Drawing.Point(603, 46);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(284, 20);
            this.SearchBox.TabIndex = 2;
            this.SearchBox.Enter += new System.EventHandler(this.SearchBox_onEnter);
            this.SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyDown);
            this.SearchBox.Leave += new System.EventHandler(this.SearchBox_onLeave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(600, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search By Tag";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(893, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "GO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.onSearchButtonClick);
            // 
            // fileTagsBindingSource1
            // 
            this.fileTagsBindingSource1.DataMember = "FileTags";
            this.fileTagsBindingSource1.DataSource = this.devOrgDBDataSetBindingSource;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "DevOrganizer";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showFormToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 48);
            // 
            // showFormToolStripMenuItem1
            // 
            this.showFormToolStripMenuItem1.Name = "showFormToolStripMenuItem1";
            this.showFormToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.showFormToolStripMenuItem1.Text = "Show Form";
            this.showFormToolStripMenuItem1.Click += new System.EventHandler(this.showFormToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fileTagsTableAdapter
            // 
            this.fileTagsTableAdapter.ClearBeforeFill = true;
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 300000;
            // 
            // newTagsContextMenu
            // 
            this.newTagsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.newTagsContextMenu.Name = "newTagsContextMenu";
            this.newTagsContextMenu.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // authorsContextMenu
            // 
            this.authorsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem1});
            this.authorsContextMenu.Name = "authorsContextMenu";
            this.authorsContextMenu.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // filepathDataGridViewTextBoxColumn
            // 
            this.filepathDataGridViewTextBoxColumn.DataPropertyName = "filepath";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.filepathDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.filepathDataGridViewTextBoxColumn.HeaderText = "filepath";
            this.filepathDataGridViewTextBoxColumn.Name = "filepathDataGridViewTextBoxColumn";
            this.filepathDataGridViewTextBoxColumn.ReadOnly = true;
            this.filepathDataGridViewTextBoxColumn.Width = 200;
            // 
            // tagsDataGridViewTextBoxColumn
            // 
            this.tagsDataGridViewTextBoxColumn.DataPropertyName = "tags";
            this.tagsDataGridViewTextBoxColumn.HeaderText = "tags";
            this.tagsDataGridViewTextBoxColumn.Name = "tagsDataGridViewTextBoxColumn";
            this.tagsDataGridViewTextBoxColumn.Width = 200;
            // 
            // author
            // 
            this.author.DataPropertyName = "author";
            this.author.HeaderText = "author";
            this.author.Name = "author";
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "description";
            this.description.Name = "description";
            this.description.Width = 300;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(956, 475);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(972, 513);
            this.Name = "Form1";
            this.Text = "DevOrganizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.addTab.ResumeLayout(false);
            this.addTab.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DatabaseTab.ResumeLayout(false);
            this.DatabaseTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devOrgDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devOrgDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileTagsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileTagsBindingSource1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.newTagsContextMenu.ResumeLayout(false);
            this.authorsContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gAYToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage addTab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage DatabaseTab;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addTagButton;
        private System.Windows.Forms.TextBox tagsTextBox;
        private System.Windows.Forms.ListBox tagsListBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton FolderOption;
        private System.Windows.Forms.RadioButton FileOption;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button addAuthorButton;
        private System.Windows.Forms.TextBox authorsTextBox;
        private System.Windows.Forms.ListBox authorsListBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.BindingSource devOrgDBDataSetBindingSource;
        private DevOrgDBDataSet devOrgDBDataSet;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.BindingSource fileTagsBindingSource;
        private DevOrgDBDataSetTableAdapters.FileTagsTableAdapter fileTagsTableAdapter;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.BindingSource fileTagsBindingSource1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem hideToSystemTrayToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showFormToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label copiedLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerOnOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerOnMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerOffMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerIntervalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minutesMenuItem_5;
        private System.Windows.Forms.ToolStripMenuItem minutesMenuItem_10;
        private System.Windows.Forms.ToolStripMenuItem minutesMenuItem_15;
        private System.Windows.Forms.ToolStripMenuItem minutesMenuItem_30;
        private System.Windows.Forms.ToolStripMenuItem hourMenuItem_1;
        private System.Windows.Forms.ToolStripMenuItem hoursMenuItem_5;
        private System.Windows.Forms.ToolStripMenuItem hoursMenuItem_10;
        private System.Windows.Forms.ToolStripMenuItem hoursMenuItem_15;
        private System.Windows.Forms.ToolStripMenuItem hoursMenuItem_24;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.ContextMenuStrip newTagsContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip authorsContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem readMeToolStripMenuItem;
        private System.Windows.Forms.Button editFilepathButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn filepathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
    }
}

