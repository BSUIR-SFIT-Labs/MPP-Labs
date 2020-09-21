using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextSorterLib;
using TextSorterLib.Sorter;

namespace TextSorterWinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void BtnGenerateFile_Click(object sender, EventArgs e)
        {
            bool isError = false;
            int fileSizeInGb = (int) NudFileSize.Value;

            var stopWatch = Stopwatch.StartNew();

            await Task.Run(() =>
            {
                try
                {
                    FileGenerator.GenerateRandomFile(TbPathToFile.Text,
                        fileSizeInGb * 1024 * 1024 * 1024,
                        Encoding.Unicode);

                    isError = false;
                }
                catch (ArgumentException)
                {
                    MessageBox.Show(@"Incorrect file path entered!", @"Error",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                    isError = true;
                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show(@"Incorrect file path entered!", @"Error",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                    isError = true;
                }
            });

            if (!isError)
            {
                LblFileGeenrationTime.Text = $@"File generation time: {stopWatch.ElapsedMilliseconds}ms";
            }
        }

        private async void BtnSortFile_Click(object sender, EventArgs e)
        {
            bool isError = false;
            var stopWatch = Stopwatch.StartNew();

            var sorter = new Sorter();
           
            await Task.Run(() =>
            {
                try
                {
                    sorter.Sort(TbPathToSrcFile.Text, TbPathToSortedFile.Text);
                    isError = false;
                }
                catch (ArgumentException) 
                { 
                    MessageBox.Show(@"Incorrect file path entered!", @"Error", 
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                    isError = true;
                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show(@"Incorrect file path entered!", @"Error",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                    isError = true;
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show(@"Incorrect file path entered!", @"Error",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                    isError = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($@"An error occurred while sorting! ERROR: {ex.Message}.", @"Error",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                    isError = true;
                }
            });

            if (!isError)
            {
                LblFileSortingTime.Text = $@"File sorting time: {stopWatch.ElapsedMilliseconds}ms";
            }
        }
    }
}
