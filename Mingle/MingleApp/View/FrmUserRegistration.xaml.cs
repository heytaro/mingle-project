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
using Microsoft.Phone.Tasks;
using System.Windows.Media.Imaging;

namespace MingleApp.View
{
    public partial class NovosUsuarios : PhoneApplicationPage
    {
        PhotoChooserTask photoChooserTask;

        public NovosUsuarios()
        {
            InitializeComponent();

            photoChooserTask = new PhotoChooserTask();
            photoChooserTask.Completed += new EventHandler<PhotoResult>(photoChooserTask_Completed);

            profileImg.Source = new BitmapImage(new Uri("/Assets/profile-image.png", UriKind.Relative));
        }

        void photoChooserTask_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                BitmapImage bi = new BitmapImage();
                bi.SetSource(e.ChosenPhoto);
                //profileImg.Source = bi;
            }
        }
        private void Salvar(object sender, RoutedEventArgs e)
        {
            App thisApp = Application.Current as App;
            Usuario u= new Usuario();
            Boolean senhainvalida = false;
            Boolean emailinvalido = false;

            if (!thisApp.appManager.getEmails().Contains(Email.Text))
            {
                if (Nome.MaxLength <= 40) { u.nome = Nome.Text; /*MessageBox.Show("foi");*/ }

                if (Email.Text.Length <= 40) { u.email = Email.Text; } 
                if (!txtSenha.Password.Any(c => char.IsSymbol(c)))
                {
                    u.senha = txtSenha.Password;
                    /*MessageBox.Show("foi"); */
                }
                else
                {
                    MessageBox.Show("A senha não pode conter caracteres especiais! Tente novamente");
                    txtSenha.Password = "";
                    senhainvalida = true;

                }

                if (!senhainvalida && !emailinvalido) 
                {
                    MessageBox.Show("Meus parabéns! Você faz parte do Mingle! agora");

                    Usuario us = new Usuario();
                    us.nome = Nome.Text;
                    us.email = Email.Text;
                    us.senha = txtSenha.Password;
                    us.sexo = "Masculino";
                    if (Boolean.Parse(Female.IsChecked.ToString())) us.sexo = "Feminino";
                    //us.fotoPerfil = profileImg;

                    thisApp.appManager.currentUser = us;

                    Nome.Text = "";
                    Email.Text = "";
                    txtSenha.Password = "";
                    if (Telefone_Usuario.Text != "")
                    {
                        Telefone_Usuario.Text = "";
                    }

                    NavigationService.Navigate(new Uri("/View/FrmStartScreen.xaml", UriKind.Relative));
                }
                
                
            }
            else
            {
                MessageBox.Show("Esse email já pertence ao Mingle!");
            }
           
        }

        private void Cancelar(object sender, RoutedEventArgs e)
        {
            Nome.Text = "";
            Email.Text = "";
            txtSenha.Password = "";
            if (Telefone_Usuario.Text != "") {
                Telefone_Usuario.Text = "";
            }
            Male.IsChecked = true;
            Female.IsChecked = false;
            NavigationService.Navigate(new Uri("/View/FrmLogin.xaml", UriKind.Relative));
        }

        private void checkMale_Click(object sender, RoutedEventArgs e)
        {
            Female.IsChecked = false;
        }

        private void checkFemale_Click(object sender, RoutedEventArgs e)
        {
            Male.IsChecked = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            photoChooserTask.Show();
        }
    }
}