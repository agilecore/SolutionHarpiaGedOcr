using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarpiaGed.Recognition.WCF
{
    public class ImageProcess
    {
        public ImageProcess()
        {
            Score = 0;
            Confidence = 0;
            Locale = String.Empty;
            Describe = String.Empty;
            PredominantColor = new List<ImageProcessColor>();
            Coordenates = new List<ImageProcessCoordenate>();
        }

        public float Score { get; set; }
        public float Confidence { get; set; }
        public String Locale { set; get; }
        public String Describe { set; get; }
        public virtual List<ImageProcessColor> PredominantColor { set; get; }
        public virtual List<ImageProcessCoordenate> Coordenates { set; get; }

    }


}
