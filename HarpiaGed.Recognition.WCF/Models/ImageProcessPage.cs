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
    public class ImageProcessPage
    {
        public ImageProcessPage()
        {
            Paragraphs = new List<ImageProcessPageParagraphs>();
        }

        public virtual List<ImageProcessPageParagraphs> Paragraphs { set; get; }

    }


}
