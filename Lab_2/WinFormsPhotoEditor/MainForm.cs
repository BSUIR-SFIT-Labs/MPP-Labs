using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsPhotoEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnLoadImage_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.Filter =
                @"Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string pathToSelectedFile = openFileDialog.FileName;

                var image = Image.FromFile(pathToSelectedFile);

                if (image.Width < PbImage.Width && image.Height < PbImage.Height)
                {
                    PbImage.SizeMode = PictureBoxSizeMode.CenterImage;
                }
                else
                {
                    PbImage.SizeMode = PictureBoxSizeMode.Zoom;
                }

                PbImage.Image = image;
            }
        }

        private void BtnRotate_Click(object sender, EventArgs e)
        {
            var image = PbImage.Image;
            image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            PbImage.Image = image;
        }
    }
}
