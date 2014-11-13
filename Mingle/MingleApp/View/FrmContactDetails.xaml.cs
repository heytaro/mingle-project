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
        }

        public void PreencherCampos()
        {
            App thisApp = Application.Current as App;
            nome.Text = thisApp.appManager.currentUser.nome;
            numero.Text = thisApp.appManager.currentUser.Telefone;
            email.Text = thisApp.appManager.currentUser.email;
            imgProf.DataContext = thisApp.appManager.currentUser.fotoPerfil;

            if (thisApp.appManager.currentUser.email == "") MessageBox.Show("Não Cadastrado");
        }
    }
}