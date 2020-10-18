using ImageProcessor;
using ImageProcessor.Imaging.Filters.Photo;
using System;
using System.Drawing;

namespace ImageEditorLib
{
    /// <summary>
    /// Edits images.
    /// </summary>
    public class ImageEditor : IDisposable
    {
        private readonly ImageFactory _editor;
        private readonly Image _startImage;

        private Image _tempImage;

        /// <summary>
        /// Initializes a new instance of <see cref="ImageEditor"/>.
        /// </summary>
        /// <param name="pathToImage">The path to the image to be edited.</param>
        public ImageEditor(string pathToImage)
        {
            _editor = new ImageFactory();
            _editor.Load(pathToImage);

            _startImage = _editor.Image;

            SaveToTempImage();
        }

        /// <summary>
        /// The current state of the image.
        /// </summary>
        public Image Image => _editor.Image;

        /// <summary>
        /// Rotates the image by the specified number of degrees.
        /// </summary>
        /// <param name="degrees">Degree of rotation.</param>
        /// <returns>The resulting image.</returns>
        public Image Rotate(float degrees)
        {
            _editor.Rotate(degrees);
            SaveToTempImage();

            return _editor.Image;
        }

        /// <summary>
        /// Rotates the image by the specified number of degrees.
        /// </summary>
        /// <param name="degrees">Degree of rotation.</param>
        /// <returns>The resulting image.</returns>
        public Image RotateManyTimes(float degrees)
        {
            _editor.Load(_tempImage);
            _editor.Rotate(degrees);

            return _editor.Image;
        }

        /// <summary>
        /// Flips the image.
        /// </summary>
        /// <param name="isVerticalFlip">Is vertical flip?</param>
        /// <returns>The resulting image.</returns>
        public Image FlipImage(bool isVerticalFlip)
        {
            _editor.Flip(isVerticalFlip);
            SaveToTempImage();

            return _editor.Image;
        }

        /// <summary>
        /// Changes the hue of the image.
        /// </summary>
        /// <param name="degrees">Hue in degrees. From 0 to 360.</param>
        /// <returns>The resulting image.</returns>
        public Image ChangeHue(int degrees)
        {
            _editor.Load(_tempImage);
            _editor.Hue(degrees);

            return _editor.Image;
        }

        /// <summary>
        /// Changes the brightness of the image.
        /// </summary>
        /// <param name="percentage">Brightness in percentage. From -100% to 100%.</param>
        /// <returns>The resulting image.</returns>
        public Image ChangeBrightness(int percentage)
        {
            _editor.Load(_tempImage);
            _editor.Brightness(percentage);

            return _editor.Image;
        }

        /// <summary>
        /// Changes the contrast of the image.
        /// </summary>
        /// <param name="percentage">Contrast in percentage. From -100% to 100%.</param>
        /// <returns>The resulting image.</returns>
        public Image ChangeContrast(int percentage)
        {
            _editor.Load(_tempImage);
            _editor.Contrast(percentage);

            return _editor.Image;
        }

        /// <summary>
        /// Changes the saturation of the image.
        /// </summary>
        /// <param name="percentage">Saturation in percentage. From -100% to 100%.</param>
        /// <returns>The resulting image.</returns>
        public Image ChangeSaturation(int percentage)
        {
            _editor.Load(_tempImage);
            _editor.Saturation(percentage);

            return _editor.Image;
        }

        /// <summary>
        /// Applies a filter to the image.
        /// </summary>
        /// <param name="imageFilters">The filter to apply to the image.</param>
        /// <returns>The resulting image.</returns>
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

        /// <summary>
        /// Resets all filters that have been applied to the image.
        /// </summary>
        /// <returns>Original image.</returns>
        public Image Reset()
        {
            _editor.Load(_startImage);
            SaveToTempImage();

            return _editor.Image;
        }

        /// <summary>
        /// Saves the edited image.
        /// </summary>
        /// <param name="pathToFile">The path to save the edited image.</param>
        public void SaveImage(string pathToFile)
        {
            _editor.Save(pathToFile);
        }

        /// <summary>
        /// Saves the result of editing to a variable.
        /// </summary>
        public void SaveToTempImage()
        {
            _tempImage = _editor.Image;
        }

        /// <summary>
        /// Cleans resources.
        /// </summary>
        public void Dispose()
        {
            _editor?.Dispose();
            _startImage?.Dispose();
            _tempImage?.Dispose();
        }
    }
}