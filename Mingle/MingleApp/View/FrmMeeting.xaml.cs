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
    public partial class FrmMeeting : PhoneApplicationPage
    {
        public FrmMeeting()
        {
            InitializeComponent();            
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            itsMap.IsEnabled = false;
        }

        private void itsMap_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/FrmMap.xaml",UriKind.Relative));
        }
    }
}