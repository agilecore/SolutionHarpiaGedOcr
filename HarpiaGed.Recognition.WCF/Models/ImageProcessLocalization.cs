using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HarpiaGed.Recognition.WCF
{
    public struct ImageProcessLocalization
    {
        public ImageProcessLocalization(double Latitude, double Longitude)
        {
            latitude = Latitude;
            longitude = Longitude;
        }

        public double latitude { get; set; }
        public double longitude { get; set; }
    }
}