using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickFlattener
{
    public partial class MainWindow : Form
    {
        private readonly UIController uiController;

        public MainWindow()
        {
            InitializeComponent();


            uiController = new UIController();

            cmbFlatteningAlgorithm.Items.Clear();
            cmbFlatteningAlgorithm.Items.AddRange(uiController.AvailableAlgorithms.Select(x => x.Key).ToArray());
            cmbFlatteningAlgorithm.SelectedIndex = 0;

            txtInputDirectory.Text = ".";
            txtOutputDirectory.Text = ".";
            txtOutputPattern.Text = "<<#ShortFilePathToken#>><<#FileNameToken#>>.<<#FileExtensionToken#>>";
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            lstFiles.Items.Clear();

            try
            {
                var files = uiController.ExecuteFlattening(txtInputDirectory.Text, txtOutputDirectory.Text, txtOutputPattern.Text, out var iFilesCount);

                lstLog.Items.Add($"Found {iFilesCount} files");

                foreach(var file in files)
                    lstFiles.Items.Add(file);
            }
            catch (DirectoryNotFoundException ex)
            {
                lstLog.Items.Add(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                lstLog.Items.Add(ex.Message);
            }
        }

        private void tokenBtn_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;

            if(btn == null)
                return;

            txtOutputPattern.Text += btn.Text;
        }

        private void clearBtn1_Click(object sender, EventArgs e)
        {
            txtInputDirectory.Text = "";
        }

        private void clearBtn2_Click(object sender, EventArgs e)
        {
            txtOutputDirectory.Text = "";
        }

        private void clearBtn3_Click(object sender, EventArgs e)
        {
            txtOutputPattern.Text = "";
        }

        private string askForFolderURL(string displayMessage, string initialPath = null)
        {
            if(initialPath != null)
                folderBrowserDialog.SelectedPath = initialPath;

            folderBrowserDialog.Description = displayMessage;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                return folderBrowserDialog.SelectedPath;

            return null;
        }

        private void searchInputDirBtn_Click(object sender, EventArgs e)
        {
            var path = askForFolderURL("Please select input directory...", txtInputDirectory.Text);

            if (path != null)
                txtInputDirectory.Text = path;
        }

        private void searchOutDir_Click(object sender, EventArgs e)
        {
            var path = askForFolderURL("Please select output directory...", txtOutputDirectory.Text);

            if (path != null)
                txtOutputDirectory.Text = path;
        }
    }
}
