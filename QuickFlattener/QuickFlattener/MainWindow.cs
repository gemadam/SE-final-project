using QuickFlattener.Dialogs;
using QuickFlattener.Flattening;
using QuickFlattener.Logging;
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
        /// <summary>
        /// Controller of the GUI.
        /// </summary>
        private readonly UIController uiController;

        /// <summary>
        /// Collection of input files. Main data structure.
        /// </summary>
        private MappedFilesCollection filesCollection;

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            filesCollection = new MappedFilesCollection();

            uiController = new UIController(new CustomLogger((string msg) =>
            {
                lstLog.Items.Add(msg);
                return true;
            }));

            /*  Main window initial control values  */
            cmbFlatteningAlgorithm.Items.Clear();
            cmbFlatteningAlgorithm.Items.AddRange(uiController.AvailableAlgorithms.Select(x => x.Key).ToArray());
            cmbFlatteningAlgorithm.SelectedIndex = 0;

            txtInputDirectory.Text = Path.GetFullPath(".");
            txtOutputDirectory.Text = Path.GetFullPath(".");
            txtOutputPattern.Text = "<<#ShortFilePathToken#>><<#FileNameToken#>>.<<#FileExtensionToken#>>";

            btnResolve.Enabled = false;
            btnExecute.Enabled = false;

            /*  Main window size and start position  */
            this.Width = (int)(0.75 * System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width);
            this.Height = (int)(0.75 * System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(
                (int)(0.125 * System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width),
                (int)(0.125 * System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height)
            );
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
            // Clear UI
            lstMappedFiles.Items.Clear();


            // Search for files and map them
            var files = uiController.Scan(txtInputDirectory.Text);
            filesCollection.mappedFiles = uiController.MapFiles(files, txtOutputPattern.Text);

            // Log number of files found
            lstLog.Items.Add($"Found {files.Count} files");

            // Log check for conflicts and log this information
            var iConflictsCount = filesCollection.ConflictsCount();
            var iConflictedFilesCount = filesCollection.ConflictedFilesCount();
            if (iConflictsCount > 0)    // At least one conflict
            {
                lstLog.Items.Add($"{iConflictsCount} conflicts between {iConflictedFilesCount} files occured.");
                btnResolve.Enabled = true;
                btnExecute.Enabled = false;
            }
            else                        // No conflicts
            {
                lstLog.Items.Add($"No conflicts occured 😁");
                btnResolve.Enabled = false;
                btnExecute.Enabled = true;
            }

            // Update UI with files mapping
            lstMappedFiles.Items.Clear();
            lstMappedFiles.Items.AddRange(filesCollection.AsStringCollection().ToArray());
        }


        /// <summary>
        /// Common handler of token buttons.
        /// </summary>
        /// <param name="sender">Token button that was clicked.</param>
        /// <param name="e">Event arguments.</param>
        private void tokenBtn_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;

            if (btn == null)
                return;

            txtOutputPattern.Text += btn.Text;
        }


        /// <summary>
        /// Common handler of clear buttons.
        /// </summary>
        /// <param name="sender">Clear button that was clicked.</param>
        /// <param name="e">Event arguments.</param>
        private void clearBtnClick(object sender, EventArgs e)
        {
            if (sender == btnClearInputDir)
                txtInputDirectory.Text = "";
            else if (sender == btnClearOutputDir)
                txtOutputDirectory.Text = "";
            else if (sender == btnClearOutputPattern)
                txtOutputPattern.Text = "";
        }


        /// <summary>
        /// Method displays modal with directory picker.
        /// </summary>
        /// <param name="displayMessage">Message to be displayed in the title.</param>
        /// <param name="initialPath">Starting path.</param>
        /// <returns>Selected directory or null if canceled.</returns>
        private string askForFolderURL(string displayMessage, string initialPath = null)
        {
            if (initialPath != null)
                folderBrowserDialog.SelectedPath = initialPath;

            folderBrowserDialog.Description = displayMessage;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                return folderBrowserDialog.SelectedPath;

            return null;
        }


        /// <summary>
        /// Common handler of search buttons. Diplays directory modal.
        /// </summary>
        /// <param name="sender">Search button that was clicked.</param>
        /// <param name="e">Event arguments.</param>
        private void searchBtn_Click(object sender, EventArgs e)
        {
            if(sender == searchInputDirBtn)
            {
                var path = askForFolderURL("Please select input directory...", txtInputDirectory.Text);

                if (path != null)
                    txtInputDirectory.Text = path;
            }
            else if(sender == searchOutDir)
            {
                var path = askForFolderURL("Please select output directory...", txtOutputDirectory.Text);

                if (path != null)
                    txtOutputDirectory.Text = path;
            }
        }


        /// <summary>
        /// Algorithm execution handler. Disables window until flattening is done.
        /// </summary>
        /// <param name="sender">Button pressed.</param>
        /// <param name="e">Event arguments.</param>
        private void btnExecute_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            uiController.ExecuteFlattening(filesCollection.AsResolvedDictionary(), txtOutputDirectory.Text);
            this.Enabled = true;
        }


        /// <summary>
        /// Conflict resolution handler.
        /// </summary>
        /// <param name="sender">Button pressed.</param>
        /// <param name="e">Event arguments.</param>
        private void btnResolve_Click(object sender, EventArgs e)
        {
            // Until there are some conflicts
            while (filesCollection.ConflictsCount() > 0)
            {
                var conflict = filesCollection.FirstConflict();

                using (ConflictResolutionWindow dialog = new ConflictResolutionWindow())
                {
                    // Select two conflicted files
                    var fileA = conflict.Value[0];
                    var fileB = conflict.Value[1];

                    // Initialize dialog
                    dialog.FileA = fileA.FullName;
                    dialog.FileB = fileB.FullName;
                    dialog.OutFileA = conflict.Key;
                    dialog.OutFileB = conflict.Key;

                    // Show dialog and wait for result
                    var result = dialog.ShowDialog(this);
                    if (result != DialogResult.OK)          // If user cancels conflict resolution abort operation
                        return;

                    // Update data structure with conflict resolution
                    filesCollection.ResolveConflict(conflict.Key, fileA, fileB, dialog.OutFileA, dialog.OutFileB);
                }

                // Update UI with new files mapping
                lstMappedFiles.Items.Clear();
                lstMappedFiles.Items.AddRange(filesCollection.AsStringCollection().ToArray());
            }

            // Rewrite mapped files to resloved files
            lstLog.Items.Add("Conflicts resolved ✔");
            btnResolve.Enabled = false;
            btnExecute.Enabled = true;
        }


        /// <summary>
        /// Clear log handler.
        /// </summary>
        /// <param name="sender">Button pressed.</param>
        /// <param name="e">Event arguments.</param>
        private void btnClearLog_Click(object sender, EventArgs e)
        {
            this.lstLog.Items.Clear();
        }

        private void cmbFlatteningAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.uiController.ChangeAlgorithm(this.cmbFlatteningAlgorithm.Text);
        }
    }
}
