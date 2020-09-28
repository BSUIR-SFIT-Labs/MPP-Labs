using ImageProcessor;
using System;
using System.Drawing;

namespace ImageEditorLib
{
    public class ImageEditor : IDisposable
    {
        private readonly ImageFactory _editor;

        private Image _tempImage;

        public Image Image => _editor.Image;

        public ImageEditor(string pathToImage)
        {
            _editor = new ImageFactory();
            _editor.Load(pathToImage);

            SaveImageInstance(_editor.Image);
        }

        public Image Rotate(float degrees)
        {
            _editor.Rotate(degrees);
            SaveImageInstance(_editor.Image);

            return _editor.Image;
        }

        private void SaveImageInstance(Image image)
        {
            _tempImage = image;
        }

        public void Dispose()
        {
            _editor?.Dispose();
            _tempImage?.Dispose();
        }
    }
}
