using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarpiaGed.Recognition.Estructure
{
    public struct Page
    {
        public List<Block> BlockCollection { get; set; }

        public Page(List<Block> collection)
        {
            BlockCollection = collection;
        }
    }
}
