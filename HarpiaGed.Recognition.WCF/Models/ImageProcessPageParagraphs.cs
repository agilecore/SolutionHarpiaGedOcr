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
    public class ImageProcessPageParagraphs
    {
        public ImageProcessPageParagraphs()
        {
            Phrase = String.Empty;
            Coordenates = new List<ImageProcessCoordenate>();
        }

        public String Phrase { set; get; }
        public List<ImageProcessCoordenate> Coordenates { set; get; }

}


}
