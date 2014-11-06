using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MingleApp.Model;
using System;

namespace MingleApp.View
{
    public partial class CadastroUsuario : PhoneApplicationPage
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtEmail.Text.Trim() == "" || txtSenha.Password.Trim() == "")
            {
                MessageBox.Show("Você precisa preencher todos os campos!");
            }
            else
            {


                App thisApp = Application.Current as App;
                
                List<String> list = thisApp.appManager.getEmails();

                if (list.Contains(txtEmail.Text.Trim()))
                {
                    Boolean bl = false;
                    foreach (Usuario u in thisApp.appManager.mingleUsers)
                    {
                        if (u.email.Equals(txtEmail.Text.Trim()) && u.senha.Equals(txtSenha.Password))
                        {
                           


                            Usuario us = new Usuario();
                            us.email = txtEmail.Text.Trim();
                            us.senha = txtSenha.Password;

                            thisApp.appManager.currentUser = u;
                            bl = true;
                        }
                    }
                    if (bl)
                    {
                        NavigationService.Navigate(new Uri("/View/FrmStartScreen.xaml", UriKind.Relative));
                    }
                    else
                    {
                        MessageBox.Show("Email e senha não correspondem");
                    }
                }
                else
                {
                    MessageBox.Show("Email não cadastrado no Mingle!");
                }
                
                //putz, eu apaguei um código que tava aqui :X
            }
            //essa main page vai para tela inicial, prq a ana colocou a main page como sendo a inicial---boba *-*
        }

        private void TextBlock_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/FrmUserRegistration.xaml", UriKind.Relative));
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            App thisApp = Application.Current as App;
            thisApp.Terminate();
        }
       
        
       
    }
}