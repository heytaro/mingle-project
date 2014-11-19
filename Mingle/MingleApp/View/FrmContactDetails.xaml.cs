using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MingleApp.View;
using MingleApp.Resources;

namespace MingleApp.View
{
    public partial class DetalhesContatos : PhoneApplicationPage
    {
        public DetalhesContatos()
        {
            InitializeComponent();
            PreencherCampos();
        }

       

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            App thisApp = Application.Current as App;

            thisApp.appManager.ContatoAtual = null;

        }

        public void PreencherCampos()
        {
            App thisApp = Application.Current as App;
           //tentar colocar o numero e o email na pagina..
            numero.Text = thisApp.appManager.ContatoAtual.telefone;
            email.Text= thisApp.appManager.ContatoAtual.email;

            if (thisApp.appManager.ContatoAtual.telefone == "") MessageBox.Show("Não Cadastrado");
        }
    }
}