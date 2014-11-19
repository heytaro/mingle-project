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
    public partial class FrmMeetingNow : PhoneApplicationPage
    {
        public FrmMeetingNow()
        {
            InitializeComponent();
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            



        }

        private void Sair_Click(object sender, EventArgs e)
        {
            var app = (Application.Current as App);
            
        }

        private void ImLost_Click(object sender, EventArgs e)
        {
            //adicionar página p/ direcionar ao ponto de encontro
            NavigationService.Navigate(new Uri("", UriKind.Relative));
        }
    }
}