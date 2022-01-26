using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickFlattener.Dialogs
{
    public partial class ConflictResolutionWindow : Form
    {
        public string FileA { get; set; }
        public string OutFileA { get; set; }

        public string FileB { get; set; }
        public string OutFileB { get; set; }


        public ConflictResolutionWindow()
        {
            InitializeComponent();


            /*  Window start position  */
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void ConflictResolutionWindow_Shown(object sender, EventArgs e)
        {
            txtOutFileA.Text = this.OutFileA;
            txtOutFileB.Text = this.OutFileB;

            txtFileA.Text = this.FileA;
            txtFileB.Text = this.FileB;

            btnResolve.Enabled = !txtOutFileA.Text.Equals(txtOutFileB.Text);
            btnTakeA.Enabled = !string.IsNullOrWhiteSpace(txtOutFileA.Text);
            btnTakeB.Enabled = !string.IsNullOrWhiteSpace(txtOutFileB.Text);
        }

        private void txtFileA_TextChanged(object sender, EventArgs e)
        {
            btnResolve.Enabled = !txtOutFileA.Text.Equals(txtOutFileB.Text);
            btnTakeA.Enabled = !string.IsNullOrWhiteSpace(txtOutFileA.Text);

            this.OutFileA = txtOutFileA.Text;
        }

        private void txtFileB_TextChanged(object sender, EventArgs e)
        {
            btnResolve.Enabled = !txtOutFileB.Text.Equals(txtOutFileA.Text);
            btnTakeB.Enabled = !string.IsNullOrWhiteSpace(txtOutFileB.Text);

            this.OutFileB = txtOutFileB.Text;
        }

        private void btnResolve_Click(object sender, EventArgs e)
        {
            this.CloseWindowSuccess();
        }

        private void btnTakeA_Click(object sender, EventArgs e)
        {
            this.OutFileB = null;
            this.CloseWindowSuccess();
        }

        private void btnTakeB_Click(object sender, EventArgs e)
        {
            this.OutFileA = null;
            this.CloseWindowSuccess();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            this.OutFileA = null;
            this.OutFileB = null;
            this.CloseWindowSuccess();
        }

        private void CloseWindowSuccess()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
