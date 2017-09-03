using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using HarpiaGed.Recognition;

namespace HarpiaGed.Recognition
{
    public class InfoImage
    {
        internal String _diretory { get; set; }
        internal Bitmap _bitmap { get; set; }
        internal Image _image { get; set; }
        public ImageDto _imageAnnotation { get; set; }
        internal Graphics _graphics { get; set; }
        public InfoImage(string diretoryImge)
        {
            Initialize(diretoryImge);

            this._imageAnnotation = new ImageDto();

            this._imageAnnotation.Width                     = _image.Width.ToString() + "px";
            this._imageAnnotation.Height                    = _image.Height.ToString() + "px";        
            this._imageAnnotation.HorizontalResolutionPpiX  = _image.HorizontalResolution.ToString() + "PpiX";
            this._imageAnnotation.VerticalResolutionPpiY    = _image.VerticalResolution.ToString() + "PpiY";       
            this._imageAnnotation.HorizontalResolutionDpiX  = _graphics.DpiX.ToString() + "DpiX";
            this._imageAnnotation.VerticalResolutionDpiY    = _graphics.DpiY.ToString() + "DpiX";         
            this._imageAnnotation.PixelFormat               = _image.PixelFormat.ToString();
            this._imageAnnotation.Interpolacao              = _graphics.InterpolationMode.ToString();
            this._imageAnnotation.Extension                 = Common.GetImageFormatString(_image);
            this._imageAnnotation.ImageByte                 = Common.ImageToByteArrayFromImage(_image);
            this._imageAnnotation.Megapixel                 = Common.GetSizeInMegapixel(_image) + "megapixel";
            this._imageAnnotation.FileSize                  = Common.GetFileSize(_diretory);

            //_imageAnnotation                         = new ImageAnnotation();
            //_imageAnnotation.AspectRadio             = Common.AspectRate(diretoryImge);
            //_imageAnnotation.Tag                     = _image.Tag;
            //_imageAnnotation.SmoothingMode           = _graphics.SmoothingMode;
            //_imageAnnotation.Palette                 = _image.Palette;
            //_imageAnnotation.PixelFormatType         = _bitmap.PixelFormat.ToString();
            //_imageAnnotation.DpiX                    = _graphics.DpiX.ToString() + "dpi";
            //_imageAnnotation.DpiY                    = _graphics.DpiY + "dpi";
            //_imageAnnotation.size                    = _bitmap.Size;
            //_imageAnnotation.Size                    = Common.GetFileSize(diretoryImge);
            //_imageAnnotation.Width                   = _bitmap.Width;
            //_imageAnnotation.Height                  = _bitmap.Height;
            //_imageAnnotation.HorizontalResolution    = _bitmap.HorizontalResolution;
            //_imageAnnotation.VerticalResolution      = _bitmap.VerticalResolution;
            //_imageAnnotation.Extension             = Common.GetImageFormatString(_image);
            //_imageAnnotation.Interpolacao            = _graphics.InterpolationMode.ToString();
            //_imageAnnotation.ImageByte               = Common.ImageToByteArrayFromImage(_image);
            //_imageAnnotation.PhisicalDimensionWidth  = _image.PhysicalDimension.Width.ToString();
            //_imageAnnotation.PhisicalDimensionHeight = _image.PhysicalDimension.Height.ToString();
            //_imageAnnotation.HorizondalResolution    = _image.HorizontalResolution.ToString() + "dpi";
            //_imageAnnotation.VeritcalResolution      = _image.VerticalResolution.ToString() + "dpi";
            //_imageAnnotation.Megapixel               = (_image.Width * _image.Height).ToString() + " megapixel";
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
