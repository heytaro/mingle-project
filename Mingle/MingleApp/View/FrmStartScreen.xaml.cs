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

        private void btnRanking_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/FrmRanking.xaml", UriKind.Relative));
        }

        private void btnEvento_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/FrmListMeetings.xaml", UriKind.Relative));
        }

        private void btnContatos_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/FrmContacts.xaml", UriKind.Relative));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/View/FrmUserRegistration.xaml", UriKind.Relative));
        }

        private void btnPerfil_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/FrmProfile.xaml", UriKind.Relative));
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            App thisApp = Application.Current as App;

            thisApp.appManager.currentUser.email = "";
            thisApp.appManager.currentUser.senha = "";
                   
            NavigationService.Navigate(new Uri("/View/FrmLogin.xaml", UriKind.Relative));
        }

        private void btnMapa_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/PageMeeting.xaml", UriKind.Relative));
        }
    }
}