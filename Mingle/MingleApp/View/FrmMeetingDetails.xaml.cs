using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace MingleApp.View
{
    public partial class FrmMeetingDetails : PhoneApplicationPage
    {
        //construtor
        public FrmMeetingDetails()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            var app = (Application.Current as App);

            panEncontro.Title = app.novoEncontro.titulo;
            lblDescricao.Text = app.novoEncontro.descricao;
            lblData.Text = app.novoEncontro.horaData.Date.ToShortDateString();
            lblHora.Text = app.novoEncontro.horaData.ToShortTimeString();
            lblLocal.Text = app.novoEncontro.local.nome;

            lstConvidados.ItemsSource = app.novoEncontro.convidados;

        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            NavigationService.GoBack();
        }


    }
}