namespace QuickFlattener
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
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.txtInputDirectory = new System.Windows.Forms.TextBox();
            this.txtOutputDirectory = new System.Windows.Forms.TextBox();
            this.txtOutputPattern = new System.Windows.Forms.TextBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.cmbFlatteningAlgorithm = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnClearInputDir = new System.Windows.Forms.Button();
            this.btnClearOutputDir = new System.Windows.Forms.Button();
            this.btnClearOutputPattern = new System.Windows.Forms.Button();
            this.searchInputDirBtn = new System.Windows.Forms.Button();
            this.searchOutDir = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnResolve = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.lstMappedFiles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstFiles
            // 
            this.lstFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(12, 121);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(675, 238);
            this.lstFiles.TabIndex = 0;
            // 
            // lstLog
            // 
            this.lstLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(693, 121);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(279, 459);
            this.lstLog.TabIndex = 1;
            // 
            // txtInputDirectory
            // 
            this.txtInputDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInputDirectory.Location = new System.Drawing.Point(60, 12);
            this.txtInputDirectory.Name = "txtInputDirectory";
            this.txtInputDirectory.Size = new System.Drawing.Size(646, 20);
            this.txtInputDirectory.TabIndex = 2;
            // 
            // txtOutputDirectory
            // 
            this.txtOutputDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputDirectory.Location = new System.Drawing.Point(60, 38);
            this.txtOutputDirectory.Name = "txtOutputDirectory";
            this.txtOutputDirectory.Size = new System.Drawing.Size(646, 20);
            this.txtOutputDirectory.TabIndex = 3;
            // 
            // txtOutputPattern
            // 
            this.txtOutputPattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputPattern.Location = new System.Drawing.Point(60, 64);
            this.txtOutputPattern.Name = "txtOutputPattern";
            this.txtOutputPattern.Size = new System.Drawing.Size(912, 20);
            this.txtOutputPattern.TabIndex = 4;
            // 
            // btnScan
            // 
            this.btnScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScan.Location = new System.Drawing.Point(765, 12);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(207, 20);
            this.btnScan.TabIndex = 5;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // cmbFlatteningAlgorithm
            // 
            this.cmbFlatteningAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFlatteningAlgorithm.FormattingEnabled = true;
            this.cmbFlatteningAlgorithm.Location = new System.Drawing.Point(765, 36);
            this.cmbFlatteningAlgorithm.Name = "cmbFlatteningAlgorithm";
            this.cmbFlatteningAlgorithm.Size = new System.Drawing.Size(207, 21);
            this.cmbFlatteningAlgorithm.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "<<#ConcatPathToken#>>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.tokenBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "<<#FileExtensionToken#>>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.tokenBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(328, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "<<#ShortFilePathToken#>>";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.tokenBtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(486, 90);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "<<#FileNameToken#>>";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.tokenBtn_Click);
            // 
            // btnClearInputDir
            // 
            this.btnClearInputDir.Location = new System.Drawing.Point(12, 12);
            this.btnClearInputDir.Name = "btnClearInputDir";
            this.btnClearInputDir.Size = new System.Drawing.Size(42, 20);
            this.btnClearInputDir.TabIndex = 11;
            this.btnClearInputDir.Text = "Clear";
            this.btnClearInputDir.UseVisualStyleBackColor = true;
            this.btnClearInputDir.Click += new System.EventHandler(this.clearBtnClick);
            // 
            // btnClearOutputDir
            // 
            this.btnClearOutputDir.Location = new System.Drawing.Point(12, 38);
            this.btnClearOutputDir.Name = "btnClearOutputDir";
            this.btnClearOutputDir.Size = new System.Drawing.Size(42, 20);
            this.btnClearOutputDir.TabIndex = 12;
            this.btnClearOutputDir.Text = "Clear";
            this.btnClearOutputDir.UseVisualStyleBackColor = true;
            this.btnClearOutputDir.Click += new System.EventHandler(this.clearBtnClick);
            // 
            // btnClearOutputPattern
            // 
            this.btnClearOutputPattern.Location = new System.Drawing.Point(12, 64);
            this.btnClearOutputPattern.Name = "btnClearOutputPattern";
            this.btnClearOutputPattern.Size = new System.Drawing.Size(42, 20);
            this.btnClearOutputPattern.TabIndex = 13;
            this.btnClearOutputPattern.Text = "Clear";
            this.btnClearOutputPattern.UseVisualStyleBackColor = true;
            this.btnClearOutputPattern.Click += new System.EventHandler(this.clearBtnClick);
            // 
            // searchInputDirBtn
            // 
            this.searchInputDirBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchInputDirBtn.Location = new System.Drawing.Point(709, 12);
            this.searchInputDirBtn.Name = "searchInputDirBtn";
            this.searchInputDirBtn.Size = new System.Drawing.Size(50, 19);
            this.searchInputDirBtn.TabIndex = 14;
            this.searchInputDirBtn.Text = "Find";
            this.searchInputDirBtn.UseVisualStyleBackColor = true;
            this.searchInputDirBtn.Click += new System.EventHandler(this.searchInputDirBtn_Click);
            // 
            // searchOutDir
            // 
            this.searchOutDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchOutDir.Location = new System.Drawing.Point(709, 38);
            this.searchOutDir.Name = "searchOutDir";
            this.searchOutDir.Size = new System.Drawing.Size(50, 19);
            this.searchOutDir.TabIndex = 15;
            this.searchOutDir.Text = "Find";
            this.searchOutDir.UseVisualStyleBackColor = true;
            this.searchOutDir.Click += new System.EventHandler(this.searchOutDir_Click);
            // 
            // btnResolve
            // 
            this.btnResolve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResolve.Location = new System.Drawing.Point(801, 90);
            this.btnResolve.Name = "btnResolve";
            this.btnResolve.Size = new System.Drawing.Size(86, 23);
            this.btnResolve.TabIndex = 16;
            this.btnResolve.Text = "Resolve";
            this.btnResolve.UseVisualStyleBackColor = true;
            this.btnResolve.Click += new System.EventHandler(this.btnResolve_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecute.Location = new System.Drawing.Point(893, 90);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(79, 23);
            this.btnExecute.TabIndex = 17;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // lstMappedFiles
            // 
            this.lstMappedFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMappedFiles.FormattingEnabled = true;
            this.lstMappedFiles.Location = new System.Drawing.Point(12, 368);
            this.lstMappedFiles.Name = "lstMappedFiles";
            this.lstMappedFiles.Size = new System.Drawing.Size(675, 212);
            this.lstMappedFiles.TabIndex = 18;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 587);
            this.Controls.Add(this.lstMappedFiles);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.btnResolve);
            this.Controls.Add(this.searchOutDir);
            this.Controls.Add(this.searchInputDirBtn);
            this.Controls.Add(this.btnClearOutputPattern);
            this.Controls.Add(this.btnClearOutputDir);
            this.Controls.Add(this.btnClearInputDir);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbFlatteningAlgorithm);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.txtOutputPattern);
            this.Controls.Add(this.txtOutputDirectory);
            this.Controls.Add(this.txtInputDirectory);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.lstFiles);
            this.Name = "MainWindow";
            this.Text = "QuickFlattener v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.TextBox txtInputDirectory;
        private System.Windows.Forms.TextBox txtOutputDirectory;
        private System.Windows.Forms.TextBox txtOutputPattern;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.ComboBox cmbFlatteningAlgorithm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnClearInputDir;
        private System.Windows.Forms.Button btnClearOutputDir;
        private System.Windows.Forms.Button btnClearOutputPattern;
        private System.Windows.Forms.Button searchInputDirBtn;
        private System.Windows.Forms.Button searchOutDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnResolve;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.ListBox lstMappedFiles;
    }
}

