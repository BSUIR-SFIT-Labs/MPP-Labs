using System;
using System.Diagnostics;
using System.IO;
using System.Text;
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

        private void BtnGenerateFile_Click(object sender, EventArgs e)
        {
            int fileSizeInGb = (int) NudFileSize.Value;

            var stopWatch = Stopwatch.StartNew();

            try
            {
                FileGenerator.GenerateRandomFile(TbPathToFile.Text,
                    fileSizeInGb * 1024 * 1024 * 1024,
                    Encoding.Unicode);

                LblFileGeenrationTime.Text = $@"File generation time: {stopWatch.ElapsedMilliseconds}ms";
            }
            catch (ArgumentException)
            {
                MessageBox.Show(@"Incorrect file path entered!", @"Error",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(@"Incorrect file path entered!", @"Error",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void BtnSortFile_Click(object sender, EventArgs e)
        {
            var stopWatch = Stopwatch.StartNew();

            var sorter = new Sorter();
            try
            {
                sorter.Sort(TbPathToSrcFile.Text, TbPathToSortedFile.Text);

                LblFileSortingTime.Text = $@"File sorting time: {stopWatch.ElapsedMilliseconds}ms";
            }
            catch (ArgumentException)
            {
                MessageBox.Show(@"Incorrect file path entered!", @"Error",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(@"Incorrect file path entered!", @"Error",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(@"Incorrect file path entered!", @"Error",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"An error occurred while sorting! ERROR: {ex.Message}.", @"Error",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
