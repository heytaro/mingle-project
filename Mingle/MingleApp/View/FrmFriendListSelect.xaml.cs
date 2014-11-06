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

namespace MingleApp.View
{
    public partial class FrmFriendListSelect : PhoneApplicationPage
    {
        //coleção que vai ser passada para preencher o binding do xaml
        private List<Usuario> listAmigos = new List<Usuario>();
        //variável encontro dessa página
        private Encontro novoEncontroAmigos;


        //construtor
        public FrmFriendListSelect()
        {
            InitializeComponent();
        }


        //pra pegar e editar a variável global
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            var app = (Application.Current as App);
            listAmigos = app.appManager.getMingleUsers();
            lstAmigos.ItemsSource = listAmigos;
            novoEncontroAmigos = app.novoEncontro;
            base.OnNavigatedTo(e);
        }


        //eventos dos botões da appbar
        private void Avancar_Click(object sender, EventArgs e)
        {
            novoEncontroAmigos.convidados = lstAmigos.SelectedItems.Cast<Usuario>().ToList();
            var app = (Application.Current as App);
            app.novoEncontro = novoEncontroAmigos;
            NavigationService.Navigate(new Uri("/View/FrmConfigureMeeting.xaml", UriKind.Relative));
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            //zera a variável de novo encontro
            var app = (Application.Current as App);
            app.novoEncontro = null;

            //volta pra main page
            NavigationService.Navigate(new Uri("/View/FrmStartScreen.xaml", UriKind.Relative));
        }
    }
}