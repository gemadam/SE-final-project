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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstLog
            // 
            this.lstLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstLog.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLog.FormattingEnabled = true;
            this.lstLog.HorizontalScrollbar = true;
            this.lstLog.ItemHeight = 20;
            this.lstLog.Location = new System.Drawing.Point(789, 168);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(304, 484);
            this.lstLog.TabIndex = 1;
            // 
            // txtInputDirectory
            // 
            this.txtInputDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInputDirectory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputDirectory.Location = new System.Drawing.Point(134, 11);
            this.txtInputDirectory.Name = "txtInputDirectory";
            this.txtInputDirectory.Size = new System.Drawing.Size(649, 27);
            this.txtInputDirectory.TabIndex = 2;
            // 
            // txtOutputDirectory
            // 
            this.txtOutputDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputDirectory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputDirectory.Location = new System.Drawing.Point(134, 38);
            this.txtOutputDirectory.Name = "txtOutputDirectory";
            this.txtOutputDirectory.Size = new System.Drawing.Size(649, 27);
            this.txtOutputDirectory.TabIndex = 3;
            // 
            // txtOutputPattern
            // 
            this.txtOutputPattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputPattern.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputPattern.Location = new System.Drawing.Point(134, 65);
            this.txtOutputPattern.Name = "txtOutputPattern";
            this.txtOutputPattern.Size = new System.Drawing.Size(649, 27);
            this.txtOutputPattern.TabIndex = 4;
            // 
            // btnScan
            // 
            this.btnScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.Location = new System.Drawing.Point(901, 11);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(192, 27);
            this.btnScan.TabIndex = 5;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // cmbFlatteningAlgorithm
            // 
            this.cmbFlatteningAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFlatteningAlgorithm.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFlatteningAlgorithm.FormattingEnabled = true;
            this.cmbFlatteningAlgorithm.Location = new System.Drawing.Point(902, 36);
            this.cmbFlatteningAlgorithm.Name = "cmbFlatteningAlgorithm";
            this.cmbFlatteningAlgorithm.Size = new System.Drawing.Size(191, 28);
            this.cmbFlatteningAlgorithm.TabIndex = 6;
            this.cmbFlatteningAlgorithm.SelectedIndexChanged += new System.EventHandler(this.cmbFlatteningAlgorithm_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "<<#ConcatPathToken#>>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.tokenBtn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(396, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "<<#FileExtensionToken#>>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.tokenBtn_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(588, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 28);
            this.button3.TabIndex = 9;
            this.button3.Text = "<<#ShortFilePathToken#>>";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.tokenBtn_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(204, 98);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 28);
            this.button4.TabIndex = 10;
            this.button4.Text = "<<#FileNameToken#>>";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.tokenBtn_Click);
            // 
            // btnClearInputDir
            // 
            this.btnClearInputDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearInputDir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearInputDir.Location = new System.Drawing.Point(789, 11);
            this.btnClearInputDir.Name = "btnClearInputDir";
            this.btnClearInputDir.Size = new System.Drawing.Size(57, 27);
            this.btnClearInputDir.TabIndex = 11;
            this.btnClearInputDir.Text = "Clear";
            this.btnClearInputDir.UseVisualStyleBackColor = true;
            this.btnClearInputDir.Click += new System.EventHandler(this.clearBtnClick);
            // 
            // btnClearOutputDir
            // 
            this.btnClearOutputDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearOutputDir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearOutputDir.Location = new System.Drawing.Point(789, 38);
            this.btnClearOutputDir.Name = "btnClearOutputDir";
            this.btnClearOutputDir.Size = new System.Drawing.Size(57, 27);
            this.btnClearOutputDir.TabIndex = 12;
            this.btnClearOutputDir.Text = "Clear";
            this.btnClearOutputDir.UseVisualStyleBackColor = true;
            this.btnClearOutputDir.Click += new System.EventHandler(this.clearBtnClick);
            // 
            // btnClearOutputPattern
            // 
            this.btnClearOutputPattern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearOutputPattern.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearOutputPattern.Location = new System.Drawing.Point(789, 65);
            this.btnClearOutputPattern.Name = "btnClearOutputPattern";
            this.btnClearOutputPattern.Size = new System.Drawing.Size(57, 27);
            this.btnClearOutputPattern.TabIndex = 13;
            this.btnClearOutputPattern.Text = "Clear";
            this.btnClearOutputPattern.UseVisualStyleBackColor = true;
            this.btnClearOutputPattern.Click += new System.EventHandler(this.clearBtnClick);
            // 
            // searchInputDirBtn
            // 
            this.searchInputDirBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchInputDirBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInputDirBtn.Location = new System.Drawing.Point(845, 11);
            this.searchInputDirBtn.Name = "searchInputDirBtn";
            this.searchInputDirBtn.Size = new System.Drawing.Size(50, 27);
            this.searchInputDirBtn.TabIndex = 14;
            this.searchInputDirBtn.Text = "Find";
            this.searchInputDirBtn.UseVisualStyleBackColor = true;
            this.searchInputDirBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchOutDir
            // 
            this.searchOutDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchOutDir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchOutDir.Location = new System.Drawing.Point(845, 38);
            this.searchOutDir.Name = "searchOutDir";
            this.searchOutDir.Size = new System.Drawing.Size(50, 27);
            this.searchOutDir.TabIndex = 15;
            this.searchOutDir.Text = "Find";
            this.searchOutDir.UseVisualStyleBackColor = true;
            this.searchOutDir.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // btnResolve
            // 
            this.btnResolve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResolve.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResolve.Location = new System.Drawing.Point(901, 65);
            this.btnResolve.Name = "btnResolve";
            this.btnResolve.Size = new System.Drawing.Size(88, 27);
            this.btnResolve.TabIndex = 16;
            this.btnResolve.Text = "Resolve";
            this.btnResolve.UseVisualStyleBackColor = true;
            this.btnResolve.Click += new System.EventHandler(this.btnResolve_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecute.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.Location = new System.Drawing.Point(995, 65);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(98, 27);
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
            this.lstMappedFiles.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMappedFiles.FormattingEnabled = true;
            this.lstMappedFiles.HorizontalScrollbar = true;
            this.lstMappedFiles.ItemHeight = 20;
            this.lstMappedFiles.Location = new System.Drawing.Point(12, 168);
            this.lstMappedFiles.Name = "lstMappedFiles";
            this.lstMappedFiles.Size = new System.Drawing.Size(771, 484);
            this.lstMappedFiles.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Output files:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(785, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Log:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Output pattern:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Output directory:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Input directory:";
            // 
            // btnClearLog
            // 
            this.btnClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearLog.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearLog.Location = new System.Drawing.Point(901, 98);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(192, 27);
            this.btnClearLog.TabIndex = 25;
            this.btnClearLog.Text = "Clear log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 662);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
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
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainWindow";
            this.Text = "QuickFlattener v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClearLog;
    }
}

