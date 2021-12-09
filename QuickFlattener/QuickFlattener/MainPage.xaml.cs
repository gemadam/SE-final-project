using QuickFlattener.Tokenization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace QuickFlattener
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            txtInputDirectory.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            txtOutputDirectory.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lstFiles.Items.Clear();

            var scanner = new FileScanner();
            var tokenizer = new Tokenizer();

            try
            {
                var files = scanner.GetFiles(txtInputDirectory.Text);

                lbFilesCount.Text = files.Count.ToString();

                foreach (var file in files)
                {
                    lstFiles.Items.Add(file.FullName);
                    lstFiles.Items.Add(tokenizer.Tokenize(txtOutputPattern.Text, file));
                }
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
    }
}
