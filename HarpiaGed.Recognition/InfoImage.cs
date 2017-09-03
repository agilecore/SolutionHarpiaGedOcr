using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace HarpiaGed.Recognition
{
    public class InfoImage
    {
        internal String _diretory { get; set; }
        internal Bitmap _bitmap { get; set; }
        internal Image _image { get; set; }
        public ImageAnnotation _imageAnnotation { get; set; }
        internal Graphics _graphics { get; set; }
        public InfoImage(string diretoryImge)
        {
            Initialize(diretoryImge);
                                                     
            _imageAnnotation                         = new ImageAnnotation();
            _imageAnnotation.AspectRadio             = Common.AspectRate(diretoryImge);
            _imageAnnotation.Tag                     = _image.Tag;
            _imageAnnotation.SmoothingMode           = _graphics.SmoothingMode;
            _imageAnnotation.Palette                 = _image.Palette;
            _imageAnnotation.PixelFormatType         = _bitmap.PixelFormat.ToString();
            _imageAnnotation.DpiX                    = _graphics.DpiX.ToString() + "dpi";
            _imageAnnotation.DpiY                    = _graphics.DpiY + "dpi";
            _imageAnnotation.size                    = _bitmap.Size;
            _imageAnnotation.Size                    = Common.GetFileSize(diretoryImge);
            _imageAnnotation.Width                   = _bitmap.Width;
            _imageAnnotation.Height                  = _bitmap.Height;
            _imageAnnotation.HorizontalResolution    = _bitmap.HorizontalResolution;
            _imageAnnotation.VerticalResolution      = _bitmap.VerticalResolution;
            _imageAnnotation.ImageFormat             = Common.GetImageFormatString(_image);
            _imageAnnotation.Interpolacao            = _graphics.InterpolationMode.ToString();
            _imageAnnotation.ImageByte               = Common.ImageToByteArrayFromImage(_image);
            _imageAnnotation.PhisicalDimensionWidth  = _image.PhysicalDimension.Width.ToString();
            _imageAnnotation.PhisicalDimensionHeight = _image.PhysicalDimension.Height.ToString();
            _imageAnnotation.HorizondalResolution    = _image.HorizontalResolution.ToString() + "dpi";
            _imageAnnotation.VeritcalResolution      = _image.VerticalResolution.ToString() + "dpi";
            _imageAnnotation.Megapixel               = (_image.Width * _image.Height).ToString() + " megapixel";
        }

        internal void Initialize(string diretoryImge)
        {
            _diretory = diretoryImge;
            _bitmap   = Common.GetBitmap(diretoryImge);
            _image    = Common.GetImage(diretoryImge);
            _graphics = Graphics.FromImage(_bitmap);          

        }

    }
}
