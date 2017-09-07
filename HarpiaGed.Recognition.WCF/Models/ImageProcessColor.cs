using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HarpiaGed.Recognition.WCF
{
    public class ImageProcessColor
    {
        public ImageProcessColor()
        {
            Blue = 0;
            Green = 0;
            Red = 0;
            PixelFraction = 0;
            Score = 0;
        }

        public float Blue { get; set; }
        public float Green { get; set; }
        public float Red { get; set; }
        public float? Alpha { get; set; }
        public float PixelFraction { get; set; }
        public float Score { get; set; }
    }
}