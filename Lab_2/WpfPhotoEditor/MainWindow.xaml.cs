using ImageEditorLib;
using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Image = System.Drawing.Image;

namespace WpfPhotoEditor
{
    public partial class MainWindow : Window
    {
        private ImageEditor _imageEditor;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Filter = @"Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png"
            };


            if (openFileDialog.ShowDialog() == true)
            {
                string pathToSelectedFile = openFileDialog.FileName;

                _imageEditor = new ImageEditor(pathToSelectedFile);
                var image = _imageEditor.Image;

                if (image.Width < (WMain.Width - GbOperations.Width - 40)
                    && image.Height < (WMain.Height - 38))
                {
                    Image.Stretch = Stretch.None;
                }
                else
                {
                    Image.Stretch = Stretch.Uniform;
                }

                ResetAllControls();
                EnableAllControls();

                Image.Source = ConvertImageToImageSource(image);
            }
        }

        private void SaveAsCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Filter = @"Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png"
            };


            if (saveFileDialog.ShowDialog() == true)
            {
                _imageEditor?.SaveImage(saveFileDialog.FileName);
            }
        }

        #region Image rotation

        private void BtnRotateToSpecDegreesRight_OnClick(object sender, RoutedEventArgs e)
        {
            int.TryParse(TbDegreeToRotate.Text, out int degreeOfRotation);

            Image.Source = ConvertImageToImageSource(_imageEditor?.RotateManyTimes(degreeOfRotation));
        }

        private void BtnRotateTo90DegreesRight_OnClick(object sender, RoutedEventArgs e)
        {
            Image.Source = ConvertImageToImageSource(_imageEditor?.Rotate(90));
        }

        private void BtnRotateTo90DegreesLeft_OnClick(object sender, RoutedEventArgs e)
        {
            Image.Source = ConvertImageToImageSource(_imageEditor?.Rotate(-90));
        }

        #endregion

        private void BtnHorizontalFlip_OnClick(object sender, RoutedEventArgs e)
        {
            Image.Source = ConvertImageToImageSource(_imageEditor?.FlipImage(false));
        }

        private void BtnVerticalFlip_OnClick(object sender, RoutedEventArgs e)
        {
            Image.Source = ConvertImageToImageSource(_imageEditor?.FlipImage(true));
        }

        private void SHue_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Image.Source = ConvertImageToImageSource(_imageEditor?.ChangeHue(Convert.ToInt32(SHue.Value)));
        }

        private void SBrightness_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Image.Source = ConvertImageToImageSource(_imageEditor?.ChangeBrightness(
                Convert.ToInt32(SBrightness.Value)));
        }

        private void SContrast_OnValueChangedContrast_OnValueChanged(object sender, 
            RoutedPropertyChangedEventArgs<double> e)
        {
            Image.Source = ConvertImageToImageSource(_imageEditor?.ChangeContrast(Convert.ToInt32(SContrast.Value)));
        }

        private void SSaturation_OnValueChangedContrast_OnValueChanged(object sender, 
            RoutedPropertyChangedEventArgs<double> e)
        {
            Image.Source = ConvertImageToImageSource(_imageEditor?.ChangeSaturation(
                Convert.ToInt32(SSaturation.Value)));
        }

        private void BtnApplyFilter_Click(object sender, RoutedEventArgs e)
        {
            int buttonTag = Convert.ToInt32((sender as Button)?.Tag);

            if (buttonTag > 0)
            {
                var filter = (ImageFilters)buttonTag;
                Image.Source = ConvertImageToImageSource(_imageEditor?.ApplyFilter(filter));
            }
        }

        private void ApplyChanges_Click(object sender, RoutedEventArgs e)
        {
            _imageEditor?.SaveToTempImage();
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            Image.Source = ConvertImageToImageSource(_imageEditor?.Reset());
            ResetAllControls();
        }

        private void ResetAllControls()
        {
            TbDegreeToRotate.Text = "0";
            SHue.Value = 0;
            SBrightness.Value = 0;
            SContrast.Value = 0;
            SSaturation.Value = 0;
        }

        private void EnableAllControls()
        {
            BtnRotateToSpecDegreesRight.IsEnabled = true;
            TbDegreeToRotate.IsEnabled = true;
            BtnSaveRotation.IsEnabled = true;
            BtnRotateTo90DegreesLeft.IsEnabled = true;
            BtnRotateTo90DegreesRight.IsEnabled = true;

            BtnHorizontalFlip.IsEnabled = true;
            BtnVerticalFlip.IsEnabled = true;

            SHue.IsEnabled = true;
            BtnSaveHue.IsEnabled = true;

            SBrightness.IsEnabled = true;
            BtnSaveBrightness.IsEnabled = true;

            SContrast.IsEnabled = true;
            BtnSaveContrast.IsEnabled = true;

            SSaturation.IsEnabled = true;
            BtnSaveSaturation.IsEnabled = true;

            BtnBlackWhiteFilter.IsEnabled = true;
            BtnComicFilter.IsEnabled = true;
            BtnGothamFilter.IsEnabled = true;
            BtnInvertFilter.IsEnabled = true;
            BtnPolaroidFilter.IsEnabled = true;
            BtnSepiaFilter.IsEnabled = true;
            BtnSaveFilters.IsEnabled = true;

            BtnReset.IsEnabled = true;
        }

        private static ImageSource ConvertImageToImageSource(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Bmp);
                ms.Seek(0, SeekOrigin.Begin);

                var bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.StreamSource = ms;
                bitmapImage.EndInit();

                return bitmapImage;
            }
        }

        private void MainWindow_OnClosing(object sender, CancelEventArgs e)
        {
            _imageEditor?.Dispose();
            _imageEditor = null;
        }
    }
}