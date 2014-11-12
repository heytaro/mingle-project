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
    public partial class FrmConfirmMeeting : PhoneApplicationPage
    {
        private Encontro novoEncontroConfirm;

        public FrmConfirmMeeting()
        {
            InitializeComponent();
        }

        //pra pegar e editar a variável global
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            var app = (Application.Current as App);
            novoEncontroConfirm = app.novoEncontro;
            base.OnNavigatedTo(e);


            //isso tá certo? o-o

            lblData.Text = novoEncontroConfirm.horaData.Date.ToShortDateString();
            lblHora.Text = novoEncontroConfirm.horaData.ToShortTimeString();

            lblTitulo.Text = novoEncontroConfirm.titulo;
            lblDescricao.Text = novoEncontroConfirm.descricao;
            lblLocal.Text = novoEncontroConfirm.local;

            lstConvidados.ItemsSource = novoEncontroConfirm.convidados;
        }

        //eventos dos botões
        private void Confirmar_Click(object sender, EventArgs e)
        {

            var app = (Application.Current as App);
            app.mingleUser.encontros.Add(app.novoEncontro);
            //EXIBE MESSAGE BOX
            MessageBox.Show("Evento adicionado com sucesso!");
            NavigationService.Navigate(new Uri("/View/FrmStartScreen.xaml", UriKind.Relative));
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            //zera a variável de novo encontro
            var app = (Application.Current as App);
            app.novoEncontro = null;

            //volta pra main page
            NavigationService.Navigate(new Uri("/View/FrmStartScreen.xaml", UriKind.Relative));
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}