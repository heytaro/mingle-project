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
using System.Threading;
using MingleApp;
using MingleApp.Model;

namespace MingleApp.View
{
    public partial class Contatos : PhoneApplicationPage
    {
        public Contatos()
        {
            InitializeComponent();
            this.Loaded += Contatos_Loaded;


        }

        void Contatos_Loaded(object sender, RoutedEventArgs e)
        {
            var app = (Application.Current as App);
            List<Usuario> contato = app.mingleUser.amigos;


            List<AlphaKeyGroup<Usuario>> list = AlphaKeyGroup<Usuario>.CreateGroups(contato, Thread.CurrentThread.CurrentUICulture, c => c.nome, true);


            llsContatos.ItemsSource = list;
        }

        private void llsContatos_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (llsContatos.SelectedItem == null)
            {

                return;
            }

            var app = Application.Current as App;
            app.appManager.currentUser = llsContatos.SelectedItem as Usuario;

            NavigationService.Navigate(new Uri("/View/FrmContactDetails.xaml", UriKind.Relative));
        }


    }
}