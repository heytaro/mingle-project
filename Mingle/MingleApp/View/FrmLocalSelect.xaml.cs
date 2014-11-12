using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MingleApp.Resources;
using System.Threading.Tasks;
using Microsoft.Phone.Maps.Services;
using System.Device.Location;
using System.Windows.Shapes;
using System.Windows.Media;
using Microsoft.Phone.Maps.Controls;
using MingleApp.Model;
using Microsoft.Phone.Maps.Toolkit;
using Windows.Devices.Geolocation;
using System.Text;

namespace MingleApp.View
{
    public partial class FrmLocalSelect : PhoneApplicationPage
    {
        MapManager mpMng = new MapManager();
        Boolean hasNamedLocal = false, hasPushpined = false;

        public FrmLocalSelect()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
 	         base.OnNavigatedTo(e);
             myLocation();
        }

        async public void myLocation()
        {
            var geolocator = new Geolocator() { DesiredAccuracyInMeters = 10 };

            var geoposition = await geolocator.GetGeopositionAsync();

            map.Center = geoposition.Coordinate.ToGeoCoordinate();
            map.ZoomLevel = 13;
            Pushpin userPin = new Pushpin()
            {
                Content = "Minha Localização",
                GeoCoordinate = map.Center
            };
            MapOverlay overlay = new MapOverlay()
            {
                GeoCoordinate = map.Center,
                Content = userPin
            };
            MapLayer layer = new MapLayer();
            layer.Add(overlay);

            map.Layers.Add(layer);

            hasPushpined = true;
            hasNamedLocal = false;
            txtEndereco.Text = "Dê um nome para o local selecionado";
            txtEndereco.Foreground = new SolidColorBrush(Colors.DarkGray);
        }


        async private void Map_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            try
            {
                //Get the current position
                var geolocator = new Geolocator() { DesiredAccuracyInMeters = 10 };

                Point p = e.GetPosition(map);
                var geoposition = map.ConvertViewportPointToGeoCoordinate(p);

                //Perform the reverse geocode query 
                var query = new ReverseGeocodeQuery() { GeoCoordinate = geoposition }; 
                var geoCodeResults = await query.GetMapLocationsAsync();
                var address = geoCodeResults.First().Information.Address; 

                this.newLayer(FormatAddress(address), geoposition);
            }
            catch (Exception ex)
            {
                if ((uint)ex.HResult == 0x80004004)
                {
                    //Location services turned off, ask user to turn it on.
                    AskUserToTurnOnLocationServices();
                }
                else
                {
                    MessageBox.Show("Algo deu errado ao tentarmos acessar sua localização :((");
                }
            }
        }

        private static async void AskUserToTurnOnLocationServices()
        {
            var result = MessageBox.Show("Esse aplicativo demanda acesso à sua localização", "Gostaria de habilitar seus recursos de localização?", MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {
                await Windows.System.Launcher.LaunchUriAsync(new Uri("ms-settings-location:"));
            }
        }

        private string FormatAddress(MapAddress address)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(address.Street).Append(",")
                .Append(address.HouseNumber).Append("\n")
                .Append(address.City).Append("\n").Append(address.StateCode).Append("\n")
                .Append(address.Country).Append("\n").Append(address.Neighborhood);

            return sb.ToString();
        }

        private string FormatCoordinates(Geoposition geoposition)
        {
            return String.Format("Latitude: {0}\nLongitude: {1}", geoposition.Coordinate.Latitude, geoposition.Coordinate.Longitude);
        }

        private void Avancar_Click(object sender, EventArgs e)
        {
            //PEGAR AS GEOCOORDENADAS
            //avança p/ seleção de amigos
            NavigationService.Navigate(new Uri("/View/FrmFriendListSelect.xaml", UriKind.Relative));
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            //zera a variável de novo encontro
            var app = (Application.Current as App);
            app.appManager.novoEncontro = null;

            //volta pra main page
            NavigationService.Navigate(new Uri("/View/MainPage.xaml", UriKind.Relative));
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            NavigationService.GoBack();
        }

        private void newLayer(string content, GeoCoordinate s)
        {
            map.Layers.Clear();

            Point p = map.ConvertGeoCoordinateToViewportPoint(s);
            Pushpin local = new Pushpin();
            local.Content = content;
            local.Height = 150;
            p.Y -= local.Height;
            s = map.ConvertViewportPointToGeoCoordinate(p);
            local.GeoCoordinate = s;

            MapLayer layer1 = new MapLayer();
            MapOverlay overlay1 = new MapOverlay();
            overlay1.Content = local;
            overlay1.GeoCoordinate = s;
            layer1.Add(overlay1);
            s = map.ConvertViewportPointToGeoCoordinate(p);
            local.GeoCoordinate = s;
            map.Layers.Add(layer1);

            hasPushpined = true;
            hasNamedLocal = false;
        }

        private void txtEndereco_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtEndereco.Text == "")
            {
                txtEndereco.Foreground = new SolidColorBrush(Colors.Gray);
                if (!hasPushpined) txtEndereco.Text = "Marque no mapa o local do encontro";
                if (hasPushpined)
                {
                    txtEndereco.Text = "Dê um nome para o local selecionado";
                    txtEndereco.Foreground = new SolidColorBrush(Colors.DarkGray);
                }

            }
            else
            {                    
                if (!(txtEndereco.Text == "Marque no mapa o local do encontro") && !(txtEndereco.Text == "Dê um nome para o local selecionado"))
                {
                    hasNamedLocal = true;
                    txtEndereco.Foreground = new SolidColorBrush(Colors.Purple);
                }
            }
        }
    }
}