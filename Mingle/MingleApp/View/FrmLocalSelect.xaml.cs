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

namespace MingleApp.View
{
    public partial class FrmLocalSelect : PhoneApplicationPage
    {
        MapManager mpMng = new MapManager();

        public FrmLocalSelect()
        {
            InitializeComponent();
        }

        private void Map_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            //  Point p = e.GetPosition(map);
            //GeoCoordinate s = map.ConvertViewportPointToGeoCoordinate(p);

            //   mpMng.Maps_ReverseGeoCoding(s);
            //txtEndereco.Text = mpMng.sb.ToString();

            Ellipse myCircle = new Ellipse();
            myCircle.Fill = new SolidColorBrush(Colors.Blue);
            myCircle.Height = 20;
            myCircle.Width = 20;
            myCircle.Opacity = 50;

            MapOverlay myLocationOverlay = new MapOverlay();
            myLocationOverlay.Content = myCircle;
            myLocationOverlay.PositionOrigin = new Point(0, 0);
            //myLocationOverlay.GeoCoordinate = s;

            MapLayer myLocationLayer = new MapLayer();
            myLocationLayer.Add(myLocationOverlay);

            //map.Layers.Add(myLocationLayer);   
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
    }
}