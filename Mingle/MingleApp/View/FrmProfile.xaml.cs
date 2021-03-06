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

            Nome_Usuario.Text = thisApp.mingleUser.nome;
           
            Email_Usuario.Text = thisApp.mingleUser.email;
            if (thisApp.mingleUser.Telefone != "")
            {
                Telefone_Usuario.Text = thisApp.appManager.currentUser.Telefone;
            }
            else Telefone_Usuario.Text = "Não Cadastrado";

            img.DataContext = thisApp.mingleUser.fotoPerfil;

            txtAtraso.Text = thisApp.mingleUser.getAtrasoScore().ToString();
            txtEncontro.Text = thisApp.mingleUser.getEncontroScore().ToString();
            txtFoto.Text = thisApp.mingleUser.getFotoScore().ToString();
            txtTotal.Text = thisApp.mingleUser.getScore().ToString();

        }


    }
}