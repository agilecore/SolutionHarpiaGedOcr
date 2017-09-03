using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarpiaGed.Recognition
{
    public class ImageDto
    {
        public string HorizontalResolutionDpiX { get; set; }
        public string VerticalResolutionDpiY { get; set; }
        public string HorizontalResolutionPpiX { get; set; }
        public string VerticalResolutionPpiY { get; set; }
        public string Megapixel { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string FileSize { get; set; }
        public string AspectRate { get; set; }
        public string Interpolacao { get; set; }
        public string PixelFormat { get; set; }
        public string Extension { get; set; }
        public byte[] ImageByte { get; set; }


    }
}
