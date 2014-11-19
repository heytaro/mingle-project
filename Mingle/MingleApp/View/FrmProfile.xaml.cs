﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MingleApp.Model;
using System.Windows.Media.Imaging;

namespace MingleApp.View
{
    public partial class PerfilUsuario : PhoneApplicationPage
    {
        public PerfilUsuario()
        {
            InitializeComponent();
            preencher();

        }

        public void preencher() 
        {
            
            App thisApp = Application.Current as App;

            Nome_Usuario.Text = thisApp.appManager.currentUser.nome;
           
            Email_Usuario.Text = thisApp.appManager.currentUser.email;
            if (thisApp.appManager.currentUser.Telefone != "")
            {
                Telefone_Usuario.Text = thisApp.appManager.currentUser.Telefone;
            }
            else Telefone_Usuario.Text = "Não Cadastrado";

            img.Source = thisApp.appManager.currentUser.fotoPerfil.Source;

            txtAtraso.Text = thisApp.appManager.currentUser.nAtrasos.ToString();
            txtEncontro.Text = thisApp.appManager.currentUser.nEncontros.ToString();
            txtFoto.Text = thisApp.appManager.currentUser.nFotos.ToString();
            txtTotal.Text = thisApp.appManager.currentUser.getScore().ToString();

        }
           

    }
}