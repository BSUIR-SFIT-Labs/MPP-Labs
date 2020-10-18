using ImageEditorLib;
using System;
using System.Windows.Forms;

namespace WinFormsPhotoEditor
{
    public partial class MainForm : Form
    {
        private ImageEditor _imageEditor;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MenuItemOpenImage_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.Filter =
                @"Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string pathToSelectedFile = openFileDialog.FileName;

                _imageEditor = new ImageEditor(pathToSelectedFile);
                var image = _imageEditor.Image;

                if (image.Width < PbImage.Width && image.Height < PbImage.Height)
                    PbImage.SizeMode = PictureBoxSizeMode.CenterImage;
                else
                    PbImage.SizeMode = PictureBoxSizeMode.Zoom;

                ResetAllControls();
                EnableAllControls();

                PbImage.Image = image;
            }
        }

        private void MenuItemSaveAsImage_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog.Filter =
                @"Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _imageEditor?.SaveImage(saveFileDialog.FileName);
            }
        }

        #region Image rotation

        private void BtnRotateTo90DegreesRight_Click(object sender, EventArgs e)
        {
            PbImage.Image = _imageEditor?.Rotate(90);
        }

        private void BtnRotateTo90DegreesLeft_Click(object sender, EventArgs e)
        {
            PbImage.Image = _imageEditor?.Rotate(-90);
        }

        private void BtnRotateToSpecDegreesRight_Click(object sender, EventArgs e)
        {
            PbImage.Image = _imageEditor?.RotateManyTimes((float)NudDegreeToRotate.Value);
        }

        #endregion

        private void BtnHorizontalFlip_Click(object sender, EventArgs e)
        {
            PbImage.Image = _imageEditor?.FlipImage(false);
        }

        private void BtnVerticalFlip_Click(object sender, EventArgs e)
        {
            PbImage.Image = _imageEditor?.FlipImage(true);
        }

        private void TbHue_Scroll(object sender, EventArgs e)
        {
            PbImage.Image = _imageEditor?.ChangeHue(TbHue.Value);
        }

        private void TbBrightness_Scroll(object sender, EventArgs e)
        {
            PbImage.Image = _imageEditor?.ChangeBrightness(TbBrightness.Value);
        }

        private void TbContrast_Scroll(object sender, EventArgs e)
        {
            PbImage.Image = _imageEditor?.ChangeContrast(TbContrast.Value);
        }

        private void TbSaturation_Scroll(object sender, EventArgs e)
        {
            PbImage.Image = _imageEditor.ChangeSaturation(TbSaturation.Value);
        }

        private void BtnApplyFilter_Click(object sender, EventArgs e)
        {
            int buttonTag = Convert.ToInt32((sender as Button)?.Tag);

            if (buttonTag > 0)
            {
                var filter = (ImageFilters)buttonTag;
                PbImage.Image = _imageEditor?.ApplyFilter(filter);
            }
        }

        private void ApplyChanges_Click(object sender, EventArgs e)
        {
            _imageEditor?.SaveToTempImage();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            PbImage.Image = _imageEditor?.Reset();
            ResetAllControls();
        }

        private void ResetAllControls()
        {
            NudDegreeToRotate.Value = 0;
            TbHue.Value = 0;
            TbBrightness.Value = 0;
            TbContrast.Value = 0;
            TbSaturation.Value = 0;
        }

        private void EnableAllControls()
        {
            BtnRotateToSpecDegreesRight.Enabled = true;
            NudDegreeToRotate.Enabled = true;
            BtnSaveRotation.Enabled = true;
            BtnRotateTo90DegreesLeft.Enabled = true;
            BtnRotateTo90DegreesRight.Enabled = true;

            BtnHorizontalFlip.Enabled = true;
            BtnVerticalFlip.Enabled = true;

            TbHue.Enabled = true;
            BtnSaveHue.Enabled = true;

            TbBrightness.Enabled = true;
            BtnSaveBrightness.Enabled = true;

            TbContrast.Enabled = true;
            BtnSaveContrast.Enabled = true;

            TbSaturation.Enabled = true;
            btnSaveSaturation.Enabled = true;

            BtnBlackWhiteFilter.Enabled = true;
            BtnComicFilter.Enabled = true;
            BtnGothamFilter.Enabled = true;
            BtnInvertFilter.Enabled = true;
            BtnPolaroidFilter.Enabled = true;
            BtnSepiaFilter.Enabled = true;
            BtnSaveFilters.Enabled = true;

            BtnReset.Enabled = true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _imageEditor?.Dispose();
            _imageEditor = null;
        }
    }
}