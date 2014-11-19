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
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MingleApp.View
{
    public partial class Ranking : PhoneApplicationPage
    { MingleManager mngMingle = new MingleManager();

        public Ranking()
        {
            InitializeComponent();
            this.createComponents();
        }
        public void createComponents()
        {
            App app = App.Current as App;
            List<Usuario> lista = mngMingle.rankingGeral();
            foreach (Usuario u in lista)
            {
                StackPanel stackLine = new StackPanel();
                stackLine.Margin = new Thickness(5);
                stackLine.Orientation = System.Windows.Controls.Orientation.Horizontal;
                stackGeral.Children.Add(stackLine);
                stackLine.HorizontalAlignment = HorizontalAlignment.Center;

                stackLine.Width = 456;
                Grid grd = new Grid();
              //  grd.Background = new SolidColorBrush(Colors.Blue);
                grd.HorizontalAlignment = HorizontalAlignment.Left;
                grd.VerticalAlignment = VerticalAlignment.Center;
                grd.Height = 30;
                grd.Width = 35;
                grd.Margin = new Thickness(0, 0, 15, 0);
                
                stackLine.Children.Add(grd);

                TextBlock txtPosicao = new TextBlock();
                txtPosicao.HorizontalAlignment = HorizontalAlignment.Center;
                txtPosicao.Text = (lista.IndexOf(u) + 1).ToString();
                //txtPosicao.Padding = new Thickness(15, 5, 5, 5);
                txtPosicao.Foreground = new SolidColorBrush(Colors.White);
                txtPosicao.FontSize = 30;
                txtPosicao.Margin = new Thickness(10, 0, 0, 0);
                txtPosicao.HorizontalAlignment = HorizontalAlignment.Center;
                txtPosicao.VerticalAlignment = VerticalAlignment.Center;
                grd.Children.Add(txtPosicao);

                ///////////
                Image img = new Image();
                img.Source = new BitmapImage(new Uri(u.fotoPerfil, UriKind.RelativeOrAbsolute));
                img.Width = 60;
                img.Height = 60;
                img.HorizontalAlignment = HorizontalAlignment.Left;
                img.VerticalAlignment = VerticalAlignment.Center;
                img.Stretch = Stretch.UniformToFill;
                stackLine.Children.Add(img);

                TextBlock txtNome = new TextBlock();
                txtNome.Text = u.nome;
                txtNome.FontSize = 30;
                txtNome.Style = (Style)app.Resources["PhoneTextTitle3Style"];
                txtNome.VerticalAlignment = VerticalAlignment.Center;

                TextBlock txtScore = new TextBlock();
                txtScore.Text = u.getScore().ToString();
                txtScore.FontSize = 30;
                txtScore.VerticalAlignment = VerticalAlignment.Center;
                txtScore.HorizontalAlignment = HorizontalAlignment.Right;

                stackLine.Children.Add(txtNome);
                stackLine.Children.Add(txtScore);
            }
            lista = mngMingle.rankingAtraso();
            foreach (Usuario u in lista)
            {
                StackPanel stackLine = new StackPanel();
                stackLine.Margin = new Thickness(5);
                stackLine.Orientation = System.Windows.Controls.Orientation.Horizontal;
                stackAtrasos.Children.Add(stackLine);
                stackLine.HorizontalAlignment = HorizontalAlignment.Center;

                stackLine.Width = 456;
                
                Grid grd = new Grid();
                //  grd.Background = new SolidColorBrush(Colors.Blue);
                grd.HorizontalAlignment = HorizontalAlignment.Left;
                grd.VerticalAlignment = VerticalAlignment.Center;
                grd.Height = 30;
                grd.Width = 35;
                grd.Margin = new Thickness(0, 0, 15, 0);

                stackLine.Children.Add(grd);

                TextBlock txtPosicao = new TextBlock();
                txtPosicao.HorizontalAlignment = HorizontalAlignment.Center;
                txtPosicao.Text = (lista.IndexOf(u) + 1).ToString();
                //txtPosicao.Padding = new Thickness(15, 5, 5, 5);
                txtPosicao.Foreground = new SolidColorBrush(Colors.White);
                txtPosicao.FontSize = 30;
                txtPosicao.Margin = new Thickness(10, 0, 0, 0);
                txtPosicao.HorizontalAlignment = HorizontalAlignment.Center;
                txtPosicao.VerticalAlignment = VerticalAlignment.Center;
                grd.Children.Add(txtPosicao);


                Image img = new Image();
                img.Source = new BitmapImage(new Uri(u.fotoPerfil, UriKind.RelativeOrAbsolute));
                img.Width = 60;
                img.Height = 60;
                img.HorizontalAlignment = HorizontalAlignment.Left;
                img.VerticalAlignment = VerticalAlignment.Center;
                img.Stretch = Stretch.UniformToFill;
                stackLine.Children.Add(img);

                TextBlock txtNome = new TextBlock();
                txtNome.Text = u.nome;
                txtNome.FontSize = 30;
                txtNome.Style = (Style)app.Resources["PhoneTextTitle3Style"];
                txtNome.VerticalAlignment = VerticalAlignment.Center;

                TextBlock txtScore = new TextBlock();
                txtScore.Text = u.getAtrasoScore().ToString();
                txtScore.FontSize = 30;
                txtScore.VerticalAlignment = VerticalAlignment.Center;
                txtScore.HorizontalAlignment = HorizontalAlignment.Right;

                stackLine.Children.Add(txtNome);
                stackLine.Children.Add(txtScore);
            }
            lista =  mngMingle.rankingEncontro();
            foreach (Usuario u in lista)
            {
                StackPanel stackLine = new StackPanel();
                stackLine.Margin = new Thickness(5);
                stackLine.Orientation = System.Windows.Controls.Orientation.Horizontal;
                stackEncontros.Children.Add(stackLine);
                stackLine.HorizontalAlignment = HorizontalAlignment.Center;

                stackLine.Width = 456;
                
                Grid grd = new Grid();
                //  grd.Background = new SolidColorBrush(Colors.Blue);
                grd.HorizontalAlignment = HorizontalAlignment.Left;
                grd.VerticalAlignment = VerticalAlignment.Center;
                grd.Height = 30;
                grd.Width = 35;
                grd.Margin = new Thickness(0, 0, 15, 0);

                stackLine.Children.Add(grd);

                TextBlock txtPosicao = new TextBlock();
                txtPosicao.HorizontalAlignment = HorizontalAlignment.Center;
                txtPosicao.Text = (lista.IndexOf(u) + 1).ToString();
                //txtPosicao.Padding = new Thickness(15, 5, 5, 5);
                txtPosicao.Foreground = new SolidColorBrush(Colors.White);
                txtPosicao.FontSize = 30;
                txtPosicao.Margin = new Thickness(10, 0, 0, 0);
                txtPosicao.HorizontalAlignment = HorizontalAlignment.Center;
                txtPosicao.VerticalAlignment = VerticalAlignment.Center;
                grd.Children.Add(txtPosicao);


                Image img = new Image();
                img.Source = new BitmapImage(new Uri(u.fotoPerfil, UriKind.RelativeOrAbsolute));
                img.Width = 60;
                img.Height = 60;
                img.HorizontalAlignment = HorizontalAlignment.Left;
                img.VerticalAlignment = VerticalAlignment.Center;
                img.Stretch = Stretch.UniformToFill;
                stackLine.Children.Add(img);

                TextBlock txtNome = new TextBlock();
                txtNome.Text = u.nome;
                txtNome.FontSize = 30;
                txtNome.Style = (Style)app.Resources["PhoneTextTitle3Style"];
                txtNome.VerticalAlignment = VerticalAlignment.Center;

                TextBlock txtScore = new TextBlock();
                txtScore.Text = u.getEncontroScore().ToString();
                txtScore.FontSize = 30;
                txtScore.VerticalAlignment = VerticalAlignment.Center;
                txtScore.HorizontalAlignment = HorizontalAlignment.Right;

                stackLine.Children.Add(txtNome);
                stackLine.Children.Add(txtScore);
            }
            lista = mngMingle.rankingCarona();
            foreach (Usuario u in lista )
            {
                StackPanel stackLine = new StackPanel();
                stackLine.Margin = new Thickness(5);
                stackLine.Orientation = System.Windows.Controls.Orientation.Horizontal;
                stackCaronas.Children.Add(stackLine);
                stackLine.HorizontalAlignment = HorizontalAlignment.Center;

                stackLine.Width = 456;
                
                Grid grd = new Grid();
                //  grd.Background = new SolidColorBrush(Colors.Blue);
                grd.HorizontalAlignment = HorizontalAlignment.Left;
                grd.VerticalAlignment = VerticalAlignment.Center;
                grd.Height = 30;
                grd.Width = 35;
                grd.Margin = new Thickness(0, 0, 15, 0);

                stackLine.Children.Add(grd);

                TextBlock txtPosicao = new TextBlock();
                txtPosicao.HorizontalAlignment = HorizontalAlignment.Center;
                txtPosicao.Text = (lista.IndexOf(u) + 1).ToString();
                //txtPosicao.Padding = new Thickness(15, 5, 5, 5);
                txtPosicao.Foreground = new SolidColorBrush(Colors.White);
                txtPosicao.FontSize = 30;
                txtPosicao.Margin = new Thickness(10, 0, 0, 0);
                txtPosicao.HorizontalAlignment = HorizontalAlignment.Center;
                txtPosicao.VerticalAlignment = VerticalAlignment.Center;
                grd.Children.Add(txtPosicao);


                Image img = new Image();
                img.Source = new BitmapImage(new Uri(u.fotoPerfil, UriKind.RelativeOrAbsolute));
                img.Width = 60;
                img.Height = 60;
                img.HorizontalAlignment = HorizontalAlignment.Left;
                img.VerticalAlignment = VerticalAlignment.Center;
                img.Stretch = Stretch.UniformToFill;
                stackLine.Children.Add(img);

                TextBlock txtNome = new TextBlock();
                txtNome.Text = u.nome;
                txtNome.FontSize = 30;
                txtNome.Style = (Style)app.Resources["PhoneTextTitle3Style"];
                txtNome.VerticalAlignment = VerticalAlignment.Center;

                TextBlock txtScore = new TextBlock();
                txtScore.Text = u.getCaronaScore().ToString();
                txtScore.FontSize = 30;
                txtScore.VerticalAlignment = VerticalAlignment.Center;
                txtScore.HorizontalAlignment = HorizontalAlignment.Right;

                stackLine.Children.Add(txtNome);
                stackLine.Children.Add(txtScore);
            }
            lista= mngMingle.rankingFoto();
            foreach (Usuario u in lista)
            {
                StackPanel stackLine = new StackPanel();
                stackLine.Margin = new Thickness(5);
                stackLine.Orientation = System.Windows.Controls.Orientation.Horizontal;
                stackFotos.Children.Add(stackLine);
                stackLine.HorizontalAlignment = HorizontalAlignment.Center;

                stackLine.Width = 456;
                
                Grid grd = new Grid();
                //  grd.Background = new SolidColorBrush(Colors.Blue);
                grd.HorizontalAlignment = HorizontalAlignment.Left;
                grd.VerticalAlignment = VerticalAlignment.Center;
                grd.Height = 30;
                grd.Width = 35;
                grd.Margin = new Thickness(0, 0, 15, 0);

                stackLine.Children.Add(grd);

                TextBlock txtPosicao = new TextBlock();
                txtPosicao.HorizontalAlignment = HorizontalAlignment.Center;
                txtPosicao.Text = (lista.IndexOf(u) + 1).ToString();
                //txtPosicao.Padding = new Thickness(15, 5, 5, 5);
                txtPosicao.Foreground = new SolidColorBrush(Colors.White);
                txtPosicao.FontSize = 30;
                txtPosicao.Margin = new Thickness(10, 0, 0, 0);
                txtPosicao.HorizontalAlignment = HorizontalAlignment.Center;
                txtPosicao.VerticalAlignment = VerticalAlignment.Center;
                grd.Children.Add(txtPosicao);


                Image img = new Image();
                img.Source = new BitmapImage(new Uri(u.fotoPerfil, UriKind.RelativeOrAbsolute));
                img.Width = 60;
                img.Height = 60;
                img.HorizontalAlignment = HorizontalAlignment.Left;
                img.VerticalAlignment = VerticalAlignment.Center;
                img.Stretch = Stretch.UniformToFill;
                stackLine.Children.Add(img);

                TextBlock txtNome = new TextBlock();
                txtNome.Text = u.nome;
                txtNome.FontSize = 30;
                txtNome.Style = (Style)app.Resources["PhoneTextTitle3Style"];
                txtNome.VerticalAlignment = VerticalAlignment.Center;

                TextBlock txtScore = new TextBlock();
                txtScore.Text = u.getFotoScore().ToString();
                txtScore.FontSize = 30;
                txtScore.VerticalAlignment = VerticalAlignment.Center;
                txtScore.HorizontalAlignment = HorizontalAlignment.Right;

                stackLine.Children.Add(txtNome);
                stackLine.Children.Add(txtScore);
            }
        }

        private T FirstChild<T>(DependencyObject parentElement) where T : DependencyObject
        {
            var count = VisualTreeHelper.GetChildrenCount(parentElement);
            if (count == 0)
                return null;

            for (int i = 0; i < count; i++)
            {
                var child = VisualTreeHelper.GetChild(parentElement, i);

                if (child != null && child is T)
                {
                    return (T)child;
                }
                else
                {
                    var result = FirstChild<T>(child);
                    if (result != null)
                        return result;

                }
            }
            return null;
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            NavigationService.GoBack();
        }
    
    }
    
}