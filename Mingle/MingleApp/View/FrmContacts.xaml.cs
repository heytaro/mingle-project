using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MingleApp.Resources;
using System.Threading;
using MingleApp;

namespace MingleApp.View
{
    public partial class Contatos : PhoneApplicationPage
    {
        public Contatos()
        {
            InitializeComponent();
            this.Loaded += Contatos_Loaded;


        }

        void Contatos_Loaded(object sender, RoutedEventArgs e)
        {
            List<ContatosUsuarios> contato = new List<ContatosUsuarios>();
            contato.Add(new ContatosUsuarios { Name = "yasmim", telefone = "97298931", email = "yasmimliborio@gmail.com" });
            contato.Add(new ContatosUsuarios { Name = "natêlia", telefone = "45432009", email = "nat@gmail.com" });
            contato.Add(new ContatosUsuarios { Name = "Camilla", telefone = "243342012", email = "cami@gmail.com" });
            contato.Add(new ContatosUsuarios { Name = "Carla", telefone = "2004249", email = "k@gmail.com" });
            contato.Add(new ContatosUsuarios { Name = "yasmine", telefone = "2002424", email = "mine@gmail.com" });
            contato.Add(new ContatosUsuarios { Name = "nathalie", telefone = "1929434", email = "nath@gmail.com" });
            contato.Add(new ContatosUsuarios { Name = "Fabio", telefone = "1982434", email = "f@gmail.com" });
            contato.Add(new ContatosUsuarios { Name = "fabianuu", telefone = "2009432", email = "fab@gmail.com" });
            contato.Add(new ContatosUsuarios { Name = "Paulo", telefone = "2007234", email = "paulo@gmail.com" });
            contato.Add(new ContatosUsuarios { Name = "Cassio", telefone = "20074324", email = "cassio@gmail.com" });
            contato.Add(new ContatosUsuarios { Name = "maria", telefone = "20144324", email = "maria@gmail.com" });
            contato.Add(new ContatosUsuarios { Name = "ana", telefone = "1985432432", email = "aninha@gmail.com" });

            List<AlphaKeyGroup<ContatosUsuarios>> list = AlphaKeyGroup<ContatosUsuarios>.CreateGroups(contato, Thread.CurrentThread.CurrentUICulture, c => c.Name, true);


            llsContatos.ItemsSource = list;
        }

        private void llsContatos_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (llsContatos.SelectedItem == null)
            {

                return;
            }
            App thisApp = Application.Current as App;

            thisApp.appManager.ContatoAtual = llsContatos.SelectedItem as ContatosUsuarios;

            NavigationService.Navigate(new Uri("/View/FrmContactDetails.xaml", UriKind.Relative));
        }


    }
}