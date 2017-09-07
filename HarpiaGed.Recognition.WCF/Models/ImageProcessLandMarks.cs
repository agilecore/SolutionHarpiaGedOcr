using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HarpiaGed.Recognition.WCF
{    public class ImageProcessLandMarks
    {
        public ImageProcessLandMarks()
        {
            Score = 0;
            Confidence = 0;
            Describe = String.Empty;
        }
        public float Score { get; set; }
        public float Confidence { get; set; }
        public ImageProcessLocalization Locations { set; get; }
        public String Describe { set; get; }

    }
}