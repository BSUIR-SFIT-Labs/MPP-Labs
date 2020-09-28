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

            SaveToTempImage();
        }

        public Image Rotate(float degrees)
        {
            _editor.Rotate(degrees);
            SaveToTempImage();

            return _editor.Image;
        }

        public Image RotateManyTimes(float degrees)
        {
            _editor.Load(_tempImage);
            _editor.Rotate(degrees);

            return _editor.Image;
        }

        public Image ChangeHue(int degrees)
        {
            _editor.Load(_tempImage);
            _editor.Hue(degrees);

            return _editor.Image;
        }

        public Image ChangeBrightness(int percentage)
        {
            _editor.Load(_tempImage);
            _editor.Brightness(percentage);

            return _editor.Image;
        }

        public void SaveToTempImage()
        {
            _tempImage = _editor.Image;
        }

        public void Dispose()
        {
            _editor?.Dispose();
            _tempImage?.Dispose();
        }
    }
}
