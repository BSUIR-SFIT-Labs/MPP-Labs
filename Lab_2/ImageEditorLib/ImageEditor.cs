using ImageProcessor;
using ImageProcessor.Imaging.Filters.Photo;
using System;
using System.Drawing;

namespace ImageEditorLib
{
    public class ImageEditor : IDisposable
    {
        private readonly ImageFactory _editor;

        private Image _startImage;
        private Image _tempImage;

        public ImageEditor(string pathToImage)
        {
            _editor = new ImageFactory();
            _editor.Load(pathToImage);

            _startImage = _editor.Image;

            SaveToTempImage();
        }

        public Image Image => _editor.Image;

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

        public Image FlipImage(bool isVerticalFlip)
        {
            _editor.Flip(isVerticalFlip);
            SaveToTempImage();

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

        public Image ChangeContrast(int percentage)
        {
            _editor.Load(_tempImage);
            _editor.Contrast(percentage);

            return _editor.Image;
        }

        public Image ChangeSaturation(int percentage)
        {
            _editor.Load(_tempImage);
            _editor.Saturation(percentage);

            return _editor.Image;
        }

        public Image ApplyFilter(ImageFilters imageFilters)
        {
            _editor.Load(_tempImage);

            IMatrixFilter filter;

            switch (imageFilters)
            {
                case ImageFilters.BlackWhite:
                    filter = MatrixFilters.BlackWhite;
                    break;
                case ImageFilters.Comic:
                    filter = MatrixFilters.Comic;
                    break;
                case ImageFilters.Gotham:
                    filter = MatrixFilters.Gotham;
                    break;
                case ImageFilters.Invert:
                    filter = MatrixFilters.Invert;
                    break;
                case ImageFilters.Polaroid:
                    filter = MatrixFilters.Polaroid;
                    break;
                case ImageFilters.Sepia:
                    filter = MatrixFilters.Sepia;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(imageFilters), imageFilters, null);
            }

            _editor.Filter(filter);

            return _editor.Image;
        }

        public Image Reset()
        {
            _editor.Load(_startImage);
            SaveToTempImage();

            return _editor.Image;
        }

        public void SaveImage(string pathToFile)
        {
            _editor.Save(pathToFile);
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