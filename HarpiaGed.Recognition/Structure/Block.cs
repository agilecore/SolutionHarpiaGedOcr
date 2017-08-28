using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarpiaGed.Recognition
{
    public struct Block
    {
        public List<Paragraph> ParagraphCollection { get; set; }

        public Block(List<Paragraph> collection)
        {
            ParagraphCollection = collection;
        }
    }
}
