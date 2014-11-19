using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingleApp.Model
{
    public class Local
    {
        public GeoCoordinate coordinate;
        public String localName;

        public Local(GeoCoordinate g, String s) {
            coordinate = g;
            localName = s;
        }


    }
}
