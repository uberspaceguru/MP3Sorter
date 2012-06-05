namespace MP3Sorter
{
    partial class MainWindow
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
            this.lstBxSrcFiles = new System.Windows.Forms.ListBox();
            this.lstBxProcFiles = new System.Windows.Forms.ListBox();
            this.btnFindDup = new System.Windows.Forms.Button();
            this.btnSelSrcDir = new System.Windows.Forms.Button();
            this.lblSrcDirPath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelDestDir = new System.Windows.Forms.Button();
            this.lblDestDirPath = new System.Windows.Forms.Label();
            this.btnListFiles = new System.Windows.Forms.Button();
            this.fldrDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.fldrDestDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMP3count = new System.Windows.Forms.Label();
            this.btnMv2Dst = new System.Windows.Forms.Button();
            this.bgWrkrFileMover = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDestCount = new System.Windows.Forms.Label();
            this.txtBxSrchString = new System.Windows.Forms.TextBox();
            this.btnLstFileTypes = new System.Windows.Forms.Button();
            this.lstVwDupe = new System.Windows.Forms.ListView();
            this.colHdrOrigFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHdrDupe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHdrDupeType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstBxSrcFiles
            // 
            this.lstBxSrcFiles.FormattingEnabled = true;
            this.lstBxSrcFiles.HorizontalScrollbar = true;
            this.lstBxSrcFiles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstBxSrcFiles.Location = new System.Drawing.Point(24, 254);
            this.lstBxSrcFiles.Name = "lstBxSrcFiles";
            this.lstBxSrcFiles.ScrollAlwaysVisible = true;
            this.lstBxSrcFiles.Size = new System.Drawing.Size(341, 173);
            this.lstBxSrcFiles.Sorted = true;
            this.lstBxSrcFiles.TabIndex = 0;
            // 
            // lstBxProcFiles
            // 
            this.lstBxProcFiles.BackColor = System.Drawing.Color.White;
            this.lstBxProcFiles.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lstBxProcFiles.FormattingEnabled = true;
            this.lstBxProcFiles.HorizontalScrollbar = true;
            this.lstBxProcFiles.Location = new System.Drawing.Point(394, 254);
            this.lstBxProcFiles.Name = "lstBxProcFiles";
            this.lstBxProcFiles.ScrollAlwaysVisible = true;
            this.lstBxProcFiles.Size = new System.Drawing.Size(397, 173);
            this.lstBxProcFiles.Sorted = true;
            this.lstBxProcFiles.TabIndex = 0;
            // 
            // btnFindDup
            // 
            this.btnFindDup.Location = new System.Drawing.Point(36, 211);
            this.btnFindDup.Name = "btnFindDup";
            this.btnFindDup.Size = new System.Drawing.Size(112, 23);
            this.btnFindDup.TabIndex = 1;
            this.btnFindDup.Text = "Find Dups";
            this.btnFindDup.UseVisualStyleBackColor = true;
            this.btnFindDup.Click += new System.EventHandler(this.btnFindDup_Click);
            // 
            // btnSelSrcDir
            // 
            this.btnSelSrcDir.Location = new System.Drawing.Point(33, 38);
            this.btnSelSrcDir.Name = "btnSelSrcDir";
            this.btnSelSrcDir.Size = new System.Drawing.Size(133, 23);
            this.btnSelSrcDir.TabIndex = 1;
            this.btnSelSrcDir.Text = "Select Src Dir";
            this.btnSelSrcDir.UseVisualStyleBackColor = true;
            this.btnSelSrcDir.Click += new System.EventHandler(this.btnSelSrcDir_Click);
            // 
            // lblSrcDirPath
            // 
            this.lblSrcDirPath.AutoSize = true;
            this.lblSrcDirPath.Location = new System.Drawing.Point(9, 9);
            this.lblSrcDirPath.Name = "lblSrcDirPath";
            this.lblSrcDirPath.Size = new System.Drawing.Size(120, 13);
            this.lblSrcDirPath.TabIndex = 2;
            this.lblSrcDirPath.Text = "Source Directory to Sort";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search String (ex: *.mp3\"):";
            // 
            // btnSelDestDir
            // 
            this.btnSelDestDir.Location = new System.Drawing.Point(33, 99);
            this.btnSelDestDir.Name = "btnSelDestDir";
            this.btnSelDestDir.Size = new System.Drawing.Size(133, 23);
            this.btnSelDestDir.TabIndex = 1;
            this.btnSelDestDir.Text = "Select Dest Dir";
            this.btnSelDestDir.UseVisualStyleBackColor = true;
            this.btnSelDestDir.Click += new System.EventHandler(this.btnSelDestDir_Click);
            // 
            // lblDestDirPath
            // 
            this.lblDestDirPath.AutoSize = true;
            this.lblDestDirPath.Location = new System.Drawing.Point(9, 79);
            this.lblDestDirPath.Name = "lblDestDirPath";
            this.lblDestDirPath.Size = new System.Drawing.Size(105, 13);
            this.lblDestDirPath.TabIndex = 2;
            this.lblDestDirPath.Text = "Destination Directory";
            // 
            // btnListFiles
            // 
            this.btnListFiles.Location = new System.Drawing.Point(33, 182);
            this.btnListFiles.Name = "btnListFiles";
            this.btnListFiles.Size = new System.Drawing.Size(112, 23);
            this.btnListFiles.TabIndex = 1;
            this.btnListFiles.Text = "List all files";
            this.btnListFiles.UseVisualStyleBackColor = true;
            this.btnListFiles.Click += new System.EventHandler(this.btnListFiles_Click);
            // 
            // fldrDlg
            // 
            this.fldrDlg.Description = "Select Source Folder Directory";
            // 
            // fldrDestDlg
            // 
            this.fldrDestDlg.Description = "Select your destination folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Source Count:";
            // 
            // lblMP3count
            // 
            this.lblMP3count.AutoSize = true;
            this.lblMP3count.Location = new System.Drawing.Point(114, 438);
            this.lblMP3count.Name = "lblMP3count";
            this.lblMP3count.Size = new System.Drawing.Size(13, 13);
            this.lblMP3count.TabIndex = 5;
            this.lblMP3count.Text = "0";
            // 
            // btnMv2Dst
            // 
            this.btnMv2Dst.Location = new System.Drawing.Point(167, 182);
            this.btnMv2Dst.Name = "btnMv2Dst";
            this.btnMv2Dst.Size = new System.Drawing.Size(112, 23);
            this.btnMv2Dst.TabIndex = 1;
            this.btnMv2Dst.Text = "Move to Dest";
            this.btnMv2Dst.UseVisualStyleBackColor = true;
            this.btnMv2Dst.Click += new System.EventHandler(this.btnMv2Dst_Click);
            // 
            // bgWrkrFileMover
            // 
            this.bgWrkrFileMover.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWrkrFileMover_DoWork);
            this.bgWrkrFileMover.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWrkrFileMover_ProgressChanged);
            this.bgWrkrFileMover.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWrkrFileMover_RunWorkerCompleted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dest Count:";
            // 
            // lblDestCount
            // 
            this.lblDestCount.AutoSize = true;
            this.lblDestCount.Location = new System.Drawing.Point(687, 438);
            this.lblDestCount.Name = "lblDestCount";
            this.lblDestCount.Size = new System.Drawing.Size(13, 13);
            this.lblDestCount.TabIndex = 5;
            this.lblDestCount.Text = "0";
            // 
            // txtBxSrchString
            // 
            this.txtBxSrchString.Location = new System.Drawing.Point(24, 156);
            this.txtBxSrchString.Name = "txtBxSrchString";
            this.txtBxSrchString.Size = new System.Drawing.Size(133, 20);
            this.txtBxSrchString.TabIndex = 7;
            // 
            // btnLstFileTypes
            // 
            this.btnLstFileTypes.Location = new System.Drawing.Point(179, 38);
            this.btnLstFileTypes.Name = "btnLstFileTypes";
            this.btnLstFileTypes.Size = new System.Drawing.Size(100, 23);
            this.btnLstFileTypes.TabIndex = 1;
            this.btnLstFileTypes.Text = "List File Types";
            this.btnLstFileTypes.UseVisualStyleBackColor = true;
            this.btnLstFileTypes.Click += new System.EventHandler(this.btnLstFileTypes_Click);
            // 
            // lstVwDupe
            // 
            this.lstVwDupe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHdrOrigFile,
            this.colHdrDupe,
            this.colHdrDupeType});
            this.lstVwDupe.Location = new System.Drawing.Point(326, 38);
            this.lstVwDupe.Name = "lstVwDupe";
            this.lstVwDupe.Size = new System.Drawing.Size(465, 196);
            this.lstVwDupe.TabIndex = 8;
            this.lstVwDupe.UseCompatibleStateImageBehavior = false;
            // 
            // colHdrOrigFile
            // 
            this.colHdrOrigFile.Text = "Original";
            // 
            // colHdrDupe
            // 
            this.colHdrDupe.Text = "Duplicate File";
            // 
            // colHdrDupeType
            // 
            this.colHdrDupeType.Text = "Duplicate Type";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 463);
            this.Controls.Add(this.lstVwDupe);
            this.Controls.Add(this.txtBxSrchString);
            this.Controls.Add(this.lblDestCount);
            this.Controls.Add(this.lblMP3count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDestDirPath);
            this.Controls.Add(this.lblSrcDirPath);
            this.Controls.Add(this.btnSelDestDir);
            this.Controls.Add(this.btnLstFileTypes);
            this.Controls.Add(this.btnSelSrcDir);
            this.Controls.Add(this.btnListFiles);
            this.Controls.Add(this.btnMv2Dst);
            this.Controls.Add(this.btnFindDup);
            this.Controls.Add(this.lstBxProcFiles);
            this.Controls.Add(this.lstBxSrcFiles);
            this.Name = "MainWindow";
            this.Text = "MP3-Sorter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxSrcFiles;
        private System.Windows.Forms.ListBox lstBxProcFiles;
        private System.Windows.Forms.Button btnFindDup;
        private System.Windows.Forms.Button btnSelSrcDir;
        private System.Windows.Forms.Label lblSrcDirPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelDestDir;
        private System.Windows.Forms.Label lblDestDirPath;
        private System.Windows.Forms.Button btnListFiles;
        private System.Windows.Forms.FolderBrowserDialog fldrDlg;
        private System.Windows.Forms.FolderBrowserDialog fldrDestDlg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMP3count;
        private System.Windows.Forms.Button btnMv2Dst;
        private System.ComponentModel.BackgroundWorker bgWrkrFileMover;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDestCount;
        private System.Windows.Forms.TextBox txtBxSrchString;
        private System.Windows.Forms.Button btnLstFileTypes;
        private System.Windows.Forms.ListView lstVwDupe;
        private System.Windows.Forms.ColumnHeader colHdrOrigFile;
        private System.Windows.Forms.ColumnHeader colHdrDupe;
        private System.Windows.Forms.ColumnHeader colHdrDupeType;
    }
}

