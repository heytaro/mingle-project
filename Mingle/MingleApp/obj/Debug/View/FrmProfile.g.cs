﻿#pragma checksum "C:\Users\ANA MARQUES\Desktop\MingleProject\Mingle\MingleApp\View\FrmProfile.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9917843C5A02565419D846535FEFC332"
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
    
    
    public partial class PerfilUsuario : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel ContentPanel;
        
        internal System.Windows.Controls.Image img;
        
        internal System.Windows.Controls.TextBlock Nome_Usuario;
        
        internal System.Windows.Controls.TextBlock Email_Usuario;
        
        internal System.Windows.Controls.TextBlock Telefone_Usuario;
        
        internal System.Windows.Controls.TextBlock txtEncontro;
        
        internal System.Windows.Controls.TextBlock txtAtraso;
        
        internal System.Windows.Controls.TextBlock txtFoto;
        
        internal System.Windows.Controls.TextBlock txtTotal;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/MingleApp;component/View/FrmProfile.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.StackPanel)(this.FindName("ContentPanel")));
            this.img = ((System.Windows.Controls.Image)(this.FindName("img")));
            this.Nome_Usuario = ((System.Windows.Controls.TextBlock)(this.FindName("Nome_Usuario")));
            this.Email_Usuario = ((System.Windows.Controls.TextBlock)(this.FindName("Email_Usuario")));
            this.Telefone_Usuario = ((System.Windows.Controls.TextBlock)(this.FindName("Telefone_Usuario")));
            this.txtEncontro = ((System.Windows.Controls.TextBlock)(this.FindName("txtEncontro")));
            this.txtAtraso = ((System.Windows.Controls.TextBlock)(this.FindName("txtAtraso")));
            this.txtFoto = ((System.Windows.Controls.TextBlock)(this.FindName("txtFoto")));
            this.txtTotal = ((System.Windows.Controls.TextBlock)(this.FindName("txtTotal")));
        }
    }
}

