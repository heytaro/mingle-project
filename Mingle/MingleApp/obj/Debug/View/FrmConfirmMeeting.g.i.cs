﻿#pragma checksum "C:\Users\ANA MARQUES\Desktop\MingleProject\Mingle\MingleApp\View\FrmConfirmMeeting.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F3718312F3C7A791FECB35C5E81E2F5B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace MingleApp.View {
    
    
    public partial class FrmConfirmMeeting : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock lblTitulo;
        
        internal System.Windows.Controls.StackPanel ContentPanel;
        
        internal System.Windows.Controls.TextBlock lblDescricao;
        
        internal System.Windows.Controls.TextBlock lblData;
        
        internal System.Windows.Controls.TextBlock lblHora;
        
        internal System.Windows.Controls.TextBlock lblLocal;
        
        internal System.Windows.Controls.ListBox lstConvidados;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/MingleApp;component/View/FrmConfirmMeeting.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.lblTitulo = ((System.Windows.Controls.TextBlock)(this.FindName("lblTitulo")));
            this.ContentPanel = ((System.Windows.Controls.StackPanel)(this.FindName("ContentPanel")));
            this.lblDescricao = ((System.Windows.Controls.TextBlock)(this.FindName("lblDescricao")));
            this.lblData = ((System.Windows.Controls.TextBlock)(this.FindName("lblData")));
            this.lblHora = ((System.Windows.Controls.TextBlock)(this.FindName("lblHora")));
            this.lblLocal = ((System.Windows.Controls.TextBlock)(this.FindName("lblLocal")));
            this.lstConvidados = ((System.Windows.Controls.ListBox)(this.FindName("lstConvidados")));
        }
    }
}

