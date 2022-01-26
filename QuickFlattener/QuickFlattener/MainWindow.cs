using QuickFlattener.Dialogs;
using QuickFlattener.Flattening;
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

        private MappedFilesCollection filesCollection;

        public MainWindow()
        {
            InitializeComponent();

            filesCollection = new MappedFilesCollection();

            uiController = new UIController();

            cmbFlatteningAlgorithm.Items.Clear();
            cmbFlatteningAlgorithm.Items.AddRange(uiController.AvailableAlgorithms.Select(x => x.Key).ToArray());
            cmbFlatteningAlgorithm.SelectedIndex = 0;

            txtInputDirectory.Text = ".";
            txtOutputDirectory.Text = ".";
            txtOutputPattern.Text = "<<#ShortFilePathToken#>><<#FileNameToken#>>.<<#FileExtensionToken#>>";

            btnResolve.Enabled = false;
            btnExecute.Enabled = false;
        }

        /// <summary>
        /// Event handler invoked when user clicks 'Scan' button.
        /// Scans directory specified in 'input directory' textbox, 
        /// maps the files according to output pattern and detects conflicts.
        /// Informations and warnings are displayed in GUI. Errors are logged on log panel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScan_Click(object sender, EventArgs e)
        {
            lstFiles.Items.Clear();
            lstMappedFiles.Items.Clear();

            try
            {
                var files = uiController.Scan(txtInputDirectory.Text);
                filesCollection.mappedFiles = uiController.MapFiles(files, txtOutputPattern.Text);

                lstLog.Items.Add($"Found {files.Count} files");

                var iConflictsCount = filesCollection.ConflictsCount();
                if(iConflictsCount > 0)
                {
                    lstLog.Items.Add($"{iConflictsCount} conflicts occured.");
                    btnResolve.Enabled = true;
                    btnExecute.Enabled = false;
                }
                else
                {
                    lstLog.Items.Add($"No conflicts occured 😁");
                    btnResolve.Enabled = false;
                    btnExecute.Enabled = true;
                }

                foreach (var file in files)
                    lstFiles.Items.Add(file);

                lstMappedFiles.Items.Clear();
                lstMappedFiles.Items.AddRange(filesCollection.AsStringCollection().ToArray());
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

        private void clearBtnClick(object sender, EventArgs e)
        {
            if(sender == btnClearInputDir)
                txtInputDirectory.Text = "";
            else if (sender == btnClearOutputDir)
                txtOutputDirectory.Text = "";
            else if (sender == btnClearOutputPattern)
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

        private void btnExecute_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            try
                {
                    var files = uiController.ExecuteFlattening(filesCollection.AsResolvedDictionary(), txtOutputDirectory.Text);

                    lstLog.Items.Add($"Diretory was successfully flattend.");
                }
                catch (DirectoryNotFoundException ex)
                {
                    lstLog.Items.Add(ex.Message);
                }
                catch (UnauthorizedAccessException ex)
                {
                    lstLog.Items.Add(ex.Message);
            }
            this.Enabled = true;
        }

        private void btnResolve_Click(object sender, EventArgs e)
        {
            // Until there are some conflicts
            while (filesCollection.ConflictsCount() > 0)
            {
                var conflict = filesCollection.FirstConflict();

                using (ConflictResolutionWindow dialog = new ConflictResolutionWindow())
                {
                    var fileA = conflict.Value[0];
                    var fileB = conflict.Value[1];

                    dialog.FileA = fileA.FullName;
                    dialog.OutFileA = conflict.Key;

                    dialog.FileB = fileB.FullName;
                    dialog.OutFileB = conflict.Key;

                    var result = dialog.ShowDialog(this);

                    if (result != DialogResult.OK)
                        return;

                    filesCollection.ResolveConflict(conflict.Key, fileA, fileB, dialog.OutFileA, dialog.OutFileB);
                }

                lstMappedFiles.Items.Clear();
                lstMappedFiles.Items.AddRange(filesCollection.AsStringCollection().ToArray());
            }

            // Rewrite mapped files to resloved files
            lstLog.Items.Add("Conflicts resolved ✔");
            btnResolve.Enabled = false;
            btnExecute.Enabled = true;
        }
    }
}
