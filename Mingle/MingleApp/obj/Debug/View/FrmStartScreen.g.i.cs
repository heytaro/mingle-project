﻿#pragma checksum "C:\Users\Usuário\Desktop\Projetos\API\DEVELOPMENT\MingleProject\Mingle\MingleApp\View\FrmStartScreen.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "525413A734879E1F545220C20468A638"
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


namespace MingleApp {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal Microsoft.Phone.Controls.HubTile btnEvento;
        
        internal Microsoft.Phone.Controls.HubTile btnGaleriaFotos;
        
        internal Microsoft.Phone.Controls.HubTile btnContatos;
        
        internal Microsoft.Phone.Controls.HubTile btnMapa;
        
        internal Microsoft.Phone.Controls.HubTile btnRanking;
        
        internal Microsoft.Phone.Controls.HubTile btnPerfil;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/MingleApp;component/View/FrmStartScreen.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.btnEvento = ((Microsoft.Phone.Controls.HubTile)(this.FindName("btnEvento")));
            this.btnGaleriaFotos = ((Microsoft.Phone.Controls.HubTile)(this.FindName("btnGaleriaFotos")));
            this.btnContatos = ((Microsoft.Phone.Controls.HubTile)(this.FindName("btnContatos")));
            this.btnMapa = ((Microsoft.Phone.Controls.HubTile)(this.FindName("btnMapa")));
            this.btnRanking = ((Microsoft.Phone.Controls.HubTile)(this.FindName("btnRanking")));
            this.btnPerfil = ((Microsoft.Phone.Controls.HubTile)(this.FindName("btnPerfil")));
        }
    }
}

