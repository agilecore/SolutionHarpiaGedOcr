using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace HarpiaGed.Recognition.WCF
{
    public class InfoImage
    {
        internal String _diretory { get; set; }
        internal Bitmap _bitmap { get; set; }
        internal Image _image { get; set; }
        internal Graphics _graphics { get; set; }
        public ImageDto _imageAnnotation { get; set; }
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
