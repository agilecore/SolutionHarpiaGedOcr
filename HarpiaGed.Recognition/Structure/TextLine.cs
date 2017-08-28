using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarpiaGed.Recognition
{
    public struct TextLine
    {
        public List<Word> WordCollection { get; set; }

        public TextLine(List<Word> collection)
        {
            WordCollection = collection;
        }
    }
}
