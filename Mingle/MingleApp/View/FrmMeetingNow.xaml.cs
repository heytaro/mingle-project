using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MingleApp.Model;
using System.Device.Location;
using Microsoft.Phone.Maps.Toolkit;
using System.Windows.Media;
using Microsoft.Phone.Maps.Controls;
using Windows.Devices.Geolocation;

namespace MingleApp.View
{
    public partial class FrmMeetingNow : PhoneApplicationPage
    {
        
        public FrmMeetingNow()
        {
            InitializeComponent();
            addLayers();
        }
        async public void myLocation()
        {
            MapManager mpMng = new MapManager();
            Geolocator myGeolocator = new Geolocator();
            Geoposition myGeoposition = await myGeolocator.GetGeopositionAsync();
            Geocoordinate myGeocoordinate = myGeoposition.Coordinate;
            GeoCoordinate myGeoCoordinate = mpMng.ConvertGeocoordinate(myGeocoordinate);

            MainMap.Center = myGeoCoordinate;
            MainMap.ZoomLevel = 13;

        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var app = Application.Current as App;

            txtTitulo.Text = app.encontroNow.titulo;
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            var app = (Application.Current as App);
            
        }

        private void ImLost_Click(object sender, EventArgs e)
        {
            //adicionar página p/ direcionar ao ponto de encontro
            NavigationService.Navigate(new Uri("", UriKind.Relative));
        }

        public void addLayers()
        {
            var app = (Application.Current as App);
            foreach (Local l in app.cordAmigos)
            {
                GeoCoordinate s = l.coordinate;
                
                Pushpin local = new Pushpin();
                local.Content = l.localName;
                local.GeoCoordinate = s;
                local.Background = new SolidColorBrush(Colors.Orange);

                MapOverlay overlay = new MapOverlay();
                overlay.Content = local;
                overlay.GeoCoordinate = s;

                MapLayer layer = new MapLayer();
                layer.Add(overlay);
                MainMap.Layers.Add(layer);
            }
        }


    }
}