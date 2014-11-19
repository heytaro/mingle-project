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
    public partial class FrmResultMeeting : PhoneApplicationPage
    {
        public FrmResultMeeting()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var app = Application.Current as App;
            txtTitulo.Text = app.encontroNow.titulo;
            
            base.OnNavigatedTo(e);
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/FrmStartScreen.xaml", UriKind.Relative));
        }
    }
}