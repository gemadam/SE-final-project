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
            this.btnTakeA.Location = new System.Drawing.Point(12, 81);
            this.btnTakeA.Name = "btnTakeA";
            this.btnTakeA.Size = new System.Drawing.Size(216, 28);
            this.btnTakeA.TabIndex = 0;
            this.btnTakeA.Text = "Take A";
            this.btnTakeA.UseVisualStyleBackColor = true;
            this.btnTakeA.Click += new System.EventHandler(this.btnTakeA_Click);
            // 
            // btnResolve
            // 
            this.btnResolve.Location = new System.Drawing.Point(12, 162);
            this.btnResolve.Name = "btnResolve";
            this.btnResolve.Size = new System.Drawing.Size(462, 50);
            this.btnResolve.TabIndex = 1;
            this.btnResolve.Text = "Resolve";
            this.btnResolve.UseVisualStyleBackColor = true;
            this.btnResolve.Click += new System.EventHandler(this.btnResolve_Click);
            // 
            // btnTakeB
            // 
            this.btnTakeB.Location = new System.Drawing.Point(258, 81);
            this.btnTakeB.Name = "btnTakeB";
            this.btnTakeB.Size = new System.Drawing.Size(216, 28);
            this.btnTakeB.TabIndex = 2;
            this.btnTakeB.Text = "Take B";
            this.btnTakeB.UseVisualStyleBackColor = true;
            this.btnTakeB.Click += new System.EventHandler(this.btnTakeB_Click);
            // 
            // txtOutFileA
            // 
            this.txtOutFileA.Location = new System.Drawing.Point(12, 55);
            this.txtOutFileA.Name = "txtOutFileA";
            this.txtOutFileA.Size = new System.Drawing.Size(216, 20);
            this.txtOutFileA.TabIndex = 3;
            this.txtOutFileA.TextChanged += new System.EventHandler(this.txtFileA_TextChanged);
            // 
            // txtOutFileB
            // 
            this.txtOutFileB.Location = new System.Drawing.Point(258, 55);
            this.txtOutFileB.Name = "txtOutFileB";
            this.txtOutFileB.Size = new System.Drawing.Size(216, 20);
            this.txtOutFileB.TabIndex = 4;
            this.txtOutFileB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOutFileB.TextChanged += new System.EventHandler(this.txtFileB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "File A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "File B";
            // 
            // txtFileA
            // 
            this.txtFileA.Enabled = false;
            this.txtFileA.Location = new System.Drawing.Point(12, 26);
            this.txtFileA.Name = "txtFileA";
            this.txtFileA.Size = new System.Drawing.Size(216, 20);
            this.txtFileA.TabIndex = 7;
            // 
            // txtFileB
            // 
            this.txtFileB.Enabled = false;
            this.txtFileB.Location = new System.Drawing.Point(258, 26);
            this.txtFileB.Name = "txtFileB";
            this.txtFileB.Size = new System.Drawing.Size(216, 20);
            this.txtFileB.TabIndex = 8;
            this.txtFileB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(12, 128);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(462, 28);
            this.btnSkip.TabIndex = 9;
            this.btnSkip.Text = "Skip both";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // ConflictResolutionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 224);
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