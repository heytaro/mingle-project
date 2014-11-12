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
    public partial class FrmConfigureMeeting : PhoneApplicationPage
    {
        //variável do encontro desse frame
        private Encontro novoEncontroConfig;

        public FrmConfigureMeeting()
        {
            InitializeComponent();
        }

        //pra pegar e editar a variável global
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            var app = (Application.Current as App);
            novoEncontroConfig = app.novoEncontro;
            base.OnNavigatedTo(e);
        }

        private void Avancar_Click(object sender, EventArgs e)
        {
            novoEncontroConfig.titulo = txtNomeEvento.Text;
            novoEncontroConfig.descricao = txtDescricaoEvento.Text;
            novoEncontroConfig.local = txtLocalEvento.Text;
            //data e hora do dtpDataEvento e tpHoraEvento sendo passadas como parâmetro do construtor DateTime
            novoEncontroConfig.horaData = ((DateTime)dtpDataEvento.Value).Date.Add(((DateTime)tpHoraEvento.Value).TimeOfDay);

            var app = (Application.Current as App);
            app.novoEncontro = novoEncontroConfig;

            NavigationService.Navigate(new Uri("/View/FrmConfirmMeeting.xaml", UriKind.Relative));
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