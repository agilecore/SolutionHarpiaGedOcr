using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarpiaGed.Recognition
{
    public struct Paragraph
    {
        public List<TextLine> TextLineCollection { get; set; }

        public Paragraph(List<TextLine> collection)
        {
            TextLineCollection = collection;
        }
    }
}
