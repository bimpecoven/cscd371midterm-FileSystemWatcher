namespace Watcher
{
    partial class FileSystemWatcher
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileSystemWatcherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeToDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.TbDirectory = new System.Windows.Forms.TextBox();
            this.CbDirectory = new System.Windows.Forms.ComboBox();
            this.CbDatabase = new System.Windows.Forms.ComboBox();
            this.TbDatabase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDatabase = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnWrite = new System.Windows.Forms.Button();
            this.BtnQuery = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DgvWatcherEvents = new System.Windows.Forms.DataGridView();
            this.ColumnFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFileType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEventType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvWatcherEvents)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileSystemWatcherToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(501, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileSystemWatcherToolStripMenuItem
            // 
            this.fileSystemWatcherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem1,
            this.stopToolStripMenuItem1});
            this.fileSystemWatcherToolStripMenuItem.Name = "fileSystemWatcherToolStripMenuItem";
            this.fileSystemWatcherToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileSystemWatcherToolStripMenuItem.Text = "&File";
            // 
            // startToolStripMenuItem1
            // 
            this.startToolStripMenuItem1.Name = "startToolStripMenuItem1";
            this.startToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.startToolStripMenuItem1.Text = "Start";
            this.startToolStripMenuItem1.Click += new System.EventHandler(this.startToolStripMenuItem1_Click);
            // 
            // stopToolStripMenuItem1
            // 
            this.stopToolStripMenuItem1.Enabled = false;
            this.stopToolStripMenuItem1.Name = "stopToolStripMenuItem1";
            this.stopToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.stopToolStripMenuItem1.Text = "Stop";
            this.stopToolStripMenuItem1.Click += new System.EventHandler(this.stopToolStripMenuItem1_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.writeToDatabaseToolStripMenuItem,
            this.queryToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "&Database";
            // 
            // writeToDatabaseToolStripMenuItem
            // 
            this.writeToDatabaseToolStripMenuItem.Enabled = false;
            this.writeToDatabaseToolStripMenuItem.Name = "writeToDatabaseToolStripMenuItem";
            this.writeToDatabaseToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.writeToDatabaseToolStripMenuItem.Text = "Write to database";
            this.writeToDatabaseToolStripMenuItem.Click += new System.EventHandler(this.writeToDatabaseToolStripMenuItem_Click);
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.Enabled = false;
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.queryToolStripMenuItem.Text = "Query";
            this.queryToolStripMenuItem.Click += new System.EventHandler(this.queryToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Enabled = false;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem_About,
            this.helpToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutToolStripMenuItem_About
            // 
            this.aboutToolStripMenuItem_About.Name = "aboutToolStripMenuItem_About";
            this.aboutToolStripMenuItem_About.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem_About.Text = "About";
            this.aboutToolStripMenuItem_About.Click += new System.EventHandler(this.aboutToolStripMenuItem_About_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a file extension, a directory,  and click Start to  begin File System Watc" +
    "her";
            // 
            // TbDirectory
            // 
            this.TbDirectory.Location = new System.Drawing.Point(58, 63);
            this.TbDirectory.Name = "TbDirectory";
            this.TbDirectory.Size = new System.Drawing.Size(240, 20);
            this.TbDirectory.TabIndex = 2;
            this.TbDirectory.Text = "C:\\";
            // 
            // CbDirectory
            // 
            this.CbDirectory.FormattingEnabled = true;
            this.CbDirectory.Items.AddRange(new object[] {
            ".txt",
            ".doc",
            ".pdf",
            ".cs",
            ".java"});
            this.CbDirectory.Location = new System.Drawing.Point(304, 62);
            this.CbDirectory.Name = "CbDirectory";
            this.CbDirectory.Size = new System.Drawing.Size(137, 21);
            this.CbDirectory.TabIndex = 4;
            // 
            // CbDatabase
            // 
            this.CbDatabase.FormattingEnabled = true;
            this.CbDatabase.Items.AddRange(new object[] {
            ".txt",
            ".doc",
            ".pdf",
            ".cs",
            ".java"});
            this.CbDatabase.Location = new System.Drawing.Point(304, 129);
            this.CbDatabase.Name = "CbDatabase";
            this.CbDatabase.Size = new System.Drawing.Size(137, 21);
            this.CbDatabase.TabIndex = 5;
            // 
            // TbDatabase
            // 
            this.TbDatabase.Location = new System.Drawing.Point(58, 130);
            this.TbDatabase.Name = "TbDatabase";
            this.TbDatabase.Size = new System.Drawing.Size(240, 20);
            this.TbDatabase.TabIndex = 3;
            this.TbDatabase.Text = "SELECT * FROM WatcherDB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Directory to watch";
            // 
            // labelDatabase
            // 
            this.labelDatabase.AutoSize = true;
            this.labelDatabase.Location = new System.Drawing.Point(55, 114);
            this.labelDatabase.Name = "labelDatabase";
            this.labelDatabase.Size = new System.Drawing.Size(167, 13);
            this.labelDatabase.TabIndex = 7;
            this.labelDatabase.Text = "Database Name/Query Command";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Monitor by extension";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Query or Write by extension";
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(58, 90);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(114, 23);
            this.BtnStart.TabIndex = 10;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Enabled = false;
            this.BtnStop.Location = new System.Drawing.Point(184, 90);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(114, 23);
            this.BtnStop.TabIndex = 11;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnWrite
            // 
            this.BtnWrite.Enabled = false;
            this.BtnWrite.Location = new System.Drawing.Point(58, 157);
            this.BtnWrite.Name = "BtnWrite";
            this.BtnWrite.Size = new System.Drawing.Size(114, 23);
            this.BtnWrite.TabIndex = 12;
            this.BtnWrite.Text = "Write to database";
            this.BtnWrite.UseVisualStyleBackColor = true;
            this.BtnWrite.Click += new System.EventHandler(this.BtnWrite_Click);
            // 
            // BtnQuery
            // 
            this.BtnQuery.Enabled = false;
            this.BtnQuery.Location = new System.Drawing.Point(178, 157);
            this.BtnQuery.Name = "BtnQuery";
            this.BtnQuery.Size = new System.Drawing.Size(56, 23);
            this.BtnQuery.TabIndex = 13;
            this.BtnQuery.Text = "Query";
            this.BtnQuery.UseVisualStyleBackColor = true;
            this.BtnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Enabled = false;
            this.BtnClear.Location = new System.Drawing.Point(242, 157);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(56, 23);
            this.BtnClear.TabIndex = 14;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "File System Watcher Events";
            // 
            // DgvWatcherEvents
            // 
            this.DgvWatcherEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvWatcherEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFileName,
            this.ColumnFileType,
            this.ColumnPath,
            this.ColumnEventType,
            this.ColumnTime});
            this.DgvWatcherEvents.Location = new System.Drawing.Point(12, 210);
            this.DgvWatcherEvents.Name = "DgvWatcherEvents";
            this.DgvWatcherEvents.Size = new System.Drawing.Size(477, 343);
            this.DgvWatcherEvents.TabIndex = 16;
            // 
            // ColumnFileName
            // 
            this.ColumnFileName.HeaderText = "File Name";
            this.ColumnFileName.Name = "ColumnFileName";
            // 
            // ColumnFileType
            // 
            this.ColumnFileType.HeaderText = "File Type";
            this.ColumnFileType.Name = "ColumnFileType";
            this.ColumnFileType.Width = 40;
            // 
            // ColumnPath
            // 
            this.ColumnPath.HeaderText = "Path";
            this.ColumnPath.Name = "ColumnPath";
            this.ColumnPath.Width = 104;
            // 
            // ColumnEventType
            // 
            this.ColumnEventType.HeaderText = "Event Type";
            this.ColumnEventType.Name = "ColumnEventType";
            this.ColumnEventType.Width = 90;
            // 
            // ColumnTime
            // 
            this.ColumnTime.HeaderText = "Time of Event";
            this.ColumnTime.Name = "ColumnTime";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 556);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(501, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(89, 17);
            this.toolStripStatusLabel1.Text = "Watcher Status:";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // FileSystemWatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 578);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.DgvWatcherEvents);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnQuery);
            this.Controls.Add(this.BtnWrite);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelDatabase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbDatabase);
            this.Controls.Add(this.CbDirectory);
            this.Controls.Add(this.TbDatabase);
            this.Controls.Add(this.TbDirectory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FileSystemWatcher";
            this.Text = "File System Watcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvWatcherEvents)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileSystemWatcherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem_About;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbDirectory;
        private System.Windows.Forms.ComboBox CbDirectory;
        private System.Windows.Forms.ComboBox CbDatabase;
        private System.Windows.Forms.TextBox TbDatabase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDatabase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnWrite;
        private System.Windows.Forms.Button BtnQuery;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DgvWatcherEvents;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFileType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEventType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem writeToDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

