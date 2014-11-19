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
using Microsoft.Phone.Maps.Toolkit;
using Microsoft.Phone.Maps.Controls;
using System.Windows.Media;

namespace MingleApp.View
{
    public partial class FrmMap : PhoneApplicationPage
    {
        public FrmMap()
        {
            InitializeComponent();

            myLocation();

        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            this.addLayers();
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

        public void addLayers()
        {
            var app = (Application.Current as App);
            foreach (Local l in app.appManager.listaLocais)
            {
                GeoCoordinate s = l.coordinate;
                //Point p = itsMap.ConvertGeoCoordinateToViewportPoint(s);
                Pushpin local = new Pushpin();
                local.Content = l.localName;
                //local.Height = 150;
                //p.Y -= 50;
                //s = itsMap.ConvertViewportPointToGeoCoordinate(p);
                local.GeoCoordinate = s;
                local.Background = new SolidColorBrush(Colors.Orange);

                MapOverlay overlay = new MapOverlay();
                overlay.Content = local;
                overlay.GeoCoordinate = s;

                MapLayer layer = new MapLayer();
                layer.Add(overlay);
                //s = itsMap.ConvertViewportPointToGeoCoordinate(p);
                //local.GeoCoordinate = s;
                itsMap.Layers.Add(layer);
            }
        }
    }
}