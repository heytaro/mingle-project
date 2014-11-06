using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Windows.Devices.Geolocation;
using System.Device.Location;
using MingleApp.Model;

namespace MingleApp.View
{
    public partial class FrmMap : PhoneApplicationPage
    {
        public FrmMap()
        {
            InitializeComponent();

            myLocation();
        }

        async public void myLocation()
        {
            MapManager mpMng = new MapManager();
            Geolocator myGeolocator = new Geolocator();
            Geoposition myGeoposition = await myGeolocator.GetGeopositionAsync();
            Geocoordinate myGeocoordinate = myGeoposition.Coordinate;
            GeoCoordinate myGeoCoordinate = mpMng.ConvertGeocoordinate(myGeocoordinate);

            itsMap.Center = myGeoCoordinate;
            itsMap.ZoomLevel = 13;

        }
    }
}