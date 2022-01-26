namespace QuickFlattener.Dialogs
{
    partial class ConflictResolutionWindow
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
            this.btnTakeA = new System.Windows.Forms.Button();
            this.btnResolve = new System.Windows.Forms.Button();
            this.btnTakeB = new System.Windows.Forms.Button();
            this.txtOutFileA = new System.Windows.Forms.TextBox();
            this.txtOutFileB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFileA = new System.Windows.Forms.TextBox();
            this.txtFileB = new System.Windows.Forms.TextBox();
            this.btnSkip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTakeA
            // 
            this.btnTakeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeA.Location = new System.Drawing.Point(12, 128);
            this.btnTakeA.Name = "btnTakeA";
            this.btnTakeA.Size = new System.Drawing.Size(566, 28);
            this.btnTakeA.TabIndex = 0;
            this.btnTakeA.Text = "Take A";
            this.btnTakeA.UseVisualStyleBackColor = true;
            this.btnTakeA.Click += new System.EventHandler(this.btnTakeA_Click);
            // 
            // btnResolve
            // 
            this.btnResolve.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResolve.Location = new System.Drawing.Point(276, 212);
            this.btnResolve.Name = "btnResolve";
            this.btnResolve.Size = new System.Drawing.Size(608, 50);
            this.btnResolve.TabIndex = 1;
            this.btnResolve.Text = "Resolve";
            this.btnResolve.UseVisualStyleBackColor = true;
            this.btnResolve.Click += new System.EventHandler(this.btnResolve_Click);
            // 
            // btnTakeB
            // 
            this.btnTakeB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTakeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeB.Location = new System.Drawing.Point(583, 128);
            this.btnTakeB.Name = "btnTakeB";
            this.btnTakeB.Size = new System.Drawing.Size(566, 28);
            this.btnTakeB.TabIndex = 2;
            this.btnTakeB.Text = "Take B";
            this.btnTakeB.UseVisualStyleBackColor = true;
            this.btnTakeB.Click += new System.EventHandler(this.btnTakeB_Click);
            // 
            // txtOutFileA
            // 
            this.txtOutFileA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutFileA.Location = new System.Drawing.Point(12, 77);
            this.txtOutFileA.Multiline = true;
            this.txtOutFileA.Name = "txtOutFileA";
            this.txtOutFileA.Size = new System.Drawing.Size(566, 45);
            this.txtOutFileA.TabIndex = 3;
            this.txtOutFileA.TextChanged += new System.EventHandler(this.txtFileA_TextChanged);
            // 
            // txtOutFileB
            // 
            this.txtOutFileB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutFileB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutFileB.Location = new System.Drawing.Point(583, 77);
            this.txtOutFileB.Multiline = true;
            this.txtOutFileB.Name = "txtOutFileB";
            this.txtOutFileB.Size = new System.Drawing.Size(566, 45);
            this.txtOutFileB.TabIndex = 4;
            this.txtOutFileB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOutFileB.TextChanged += new System.EventHandler(this.txtFileB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "File A";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1110, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "File B";
            // 
            // txtFileA
            // 
            this.txtFileA.Enabled = false;
            this.txtFileA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileA.Location = new System.Drawing.Point(12, 26);
            this.txtFileA.Multiline = true;
            this.txtFileA.Name = "txtFileA";
            this.txtFileA.Size = new System.Drawing.Size(566, 45);
            this.txtFileA.TabIndex = 7;
            // 
            // txtFileB
            // 
            this.txtFileB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileB.Enabled = false;
            this.txtFileB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileB.Location = new System.Drawing.Point(583, 26);
            this.txtFileB.Multiline = true;
            this.txtFileB.Name = "txtFileB";
            this.txtFileB.Size = new System.Drawing.Size(566, 45);
            this.txtFileB.TabIndex = 8;
            this.txtFileB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSkip
            // 
            this.btnSkip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.Location = new System.Drawing.Point(276, 178);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(608, 28);
            this.btnSkip.TabIndex = 9;
            this.btnSkip.Text = "Skip both";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // ConflictResolutionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 274);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.txtFileB);
            this.Controls.Add(this.txtFileA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutFileB);
            this.Controls.Add(this.txtOutFileA);
            this.Controls.Add(this.btnTakeB);
            this.Controls.Add(this.btnResolve);
            this.Controls.Add(this.btnTakeA);
            this.Name = "ConflictResolutionWindow";
            this.Text = "Conflict Resolution";
            this.Shown += new System.EventHandler(this.ConflictResolutionWindow_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTakeA;
        private System.Windows.Forms.Button btnResolve;
        private System.Windows.Forms.Button btnTakeB;
        private System.Windows.Forms.TextBox txtOutFileA;
        private System.Windows.Forms.TextBox txtOutFileB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFileA;
        private System.Windows.Forms.TextBox txtFileB;
        private System.Windows.Forms.Button btnSkip;
    }
}