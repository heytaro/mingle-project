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
using MingleApp.Model;

namespace MingleApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        MingleManager appManager;
        public MainPage()
        {
            InitializeComponent();
            appManager = new MingleManager();
        }


        //função chamada quando este frame é chamado:
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            NavigationService.RemoveBackEntry();
        }

        private void btnContatos_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/FrmContacts.xaml", UriKind.Relative));
        }

        private void btnEvento_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/FrmListMeetings.xaml", UriKind.Relative));
        }

        private void btnMapa_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/FrmMap.xaml", UriKind.Relative));
        }

        private void btnGaleriaFotos_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            //NavigationService.Navigate(new Uri("/View/Frm.xaml", UriKind.Relative));
        }

        private void btnRanking_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/FrmRanking.xaml", UriKind.Relative));
        }

        private void btnPerfil_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/FrmProfile.xaml", UriKind.Relative));
        }
    }
}