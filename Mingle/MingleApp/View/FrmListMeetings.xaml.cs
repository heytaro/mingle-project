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
using System.Windows.Media;
using System.Threading;

namespace MingleApp.View
{
    public partial class FrmListMeetings : PhoneApplicationPage
    {

        private List<Encontro> listEventos;

        public FrmListMeetings()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            //CreateComponents();
            var app = (Application.Current as App);
            listEventos = app.mingleUser.getEncontros();
            List<AlphaKeyGroup<Encontro>> list = AlphaKeyGroup<Encontro>.CreateGroups(listEventos, Thread.CurrentThread.CurrentUICulture, c => c.titulo, true);
            lstEventos.ItemsSource = list;
        }

        private void NovoEvento_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/FrmLocalSelect.xaml", UriKind.Relative));
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            //buscar
        }

        private void llsContatos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstEventos.SelectedItem == null)
            {
                return;
            }

            App app = Application.Current as App;
            //O novoEncontro está recebendo o item selecionado, p/ que ele possa ser acessado na tela seguinte (FrmMeetingDetails)
            app.novoEncontro = lstEventos.SelectedItem as Encontro;
            //CRIAR A FRMMEETINGDETAILS
            NavigationService.Navigate(new Uri("/View/FrmMeetingDetails.xaml", UriKind.Relative));
        }

    }
}