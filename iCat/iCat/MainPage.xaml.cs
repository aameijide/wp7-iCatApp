using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Windows.Media.Imaging;

namespace iCat
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Establecer el contexto de datos del control ListBox control en los datos de ejemplo
            DataContext = App.ViewModel;
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
        }

        // Cargar datos para los elementos ViewModel
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void play_icat_Click(object sender, RoutedEventArgs e)
        {
            if (icat_text.Text.Equals("Play")) {
                icat_text.Text = "Stop";
                icat_image.Source = new BitmapImage(new Uri("Images\\pause.png", UriKind.RelativeOrAbsolute));
                icat.Play();

                icatronica.Pause();
                icatjazz.Pause();
                musicatles.Pause();
                totcat.Pause();
                mediterradio.Pause();

                icatronica_text.Text = "Play";
                icatjazz_text.Text = "Play";
                musicatles_text.Text = "Play";
                totcat_text.Text = "Play";
                mediterradio_text.Text = "Play";

                icatronica_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                icatjazz_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                musicatles_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                totcat_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                mediterradio_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
            }else{
                icat_text.Text = "Play";
                icat_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                icat.Pause();
            }
        }

        private void play_icatronica_Click(object sender, RoutedEventArgs e)
        {
            if (icatronica_text.Text.Equals("Play"))
            {
                icatronica_text.Text = "Stop";
                icatronica_image.Source = new BitmapImage(new Uri("Images\\pause.png", UriKind.RelativeOrAbsolute));
                icatronica.Play();

                icat.Pause();
                icatjazz.Pause();
                musicatles.Pause();
                totcat.Pause();
                mediterradio.Pause();

                icat_text.Text = "Play";
                icatjazz_text.Text = "Play";
                musicatles_text.Text = "Play";
                totcat_text.Text = "Play";
                mediterradio_text.Text = "Play";

                icat_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                icatjazz_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                musicatles_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                totcat_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                mediterradio_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
            }else{
                icatronica_text.Text = "Play";
                icatronica_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                icatronica.Pause();
            }
        }

        private void play_icatjazz_Click(object sender, RoutedEventArgs e)
        {
            if (icatjazz_text.Text.Equals("Play"))
            {
                icatjazz_text.Text = "Stop";
                icatjazz_image.Source = new BitmapImage(new Uri("Images\\pause.png", UriKind.RelativeOrAbsolute));
                icatjazz.Play();

                icat.Pause();
                icatronica.Pause();
                musicatles.Pause();
                totcat.Pause();
                mediterradio.Pause();

                icat_text.Text = "Play";
                icatronica_text.Text = "Play";
                musicatles_text.Text = "Play";
                totcat_text.Text = "Play";
                mediterradio_text.Text = "Play";

                icat_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                icatronica_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                musicatles_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                totcat_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                mediterradio_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
            }
            else
            {
                icatjazz_text.Text = "Play";
                icatjazz_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                icatjazz.Pause();
            }
        }

        private void play_musicatles_Click(object sender, RoutedEventArgs e)
        {
            if (musicatles_text.Text.Equals("Play"))
            {
                musicatles_text.Text = "Stop";
                musicatles_image.Source = new BitmapImage(new Uri("Images\\pause.png", UriKind.RelativeOrAbsolute));
                musicatles.Play();

                icat.Pause();
                icatronica.Pause();
                icatjazz.Pause();
                totcat.Pause();
                mediterradio.Pause();

                icat_text.Text = "Play";
                icatronica_text.Text = "Play";
                icatjazz_text.Text = "Play";
                totcat_text.Text = "Play";
                mediterradio_text.Text = "Play";

                icat_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                icatronica_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                icatjazz_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                totcat_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                mediterradio_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
            }
            else
            {
                musicatles_text.Text = "Play";
                musicatles_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                musicatles.Pause();
            }
        }

        private void play_totcat_Click(object sender, RoutedEventArgs e)
        {
            if (totcat_text.Text.Equals("Play"))
            {
                totcat_text.Text = "Stop";
                totcat_image.Source = new BitmapImage(new Uri("Images\\pause.png", UriKind.RelativeOrAbsolute));
                totcat.Play();

                icat.Pause();
                icatronica.Pause();
                icatjazz.Pause();
                musicatles.Pause();
                mediterradio.Pause();

                icat_text.Text = "Play";
                icatronica_text.Text = "Play";
                icatjazz_text.Text = "Play";
                musicatles_text.Text = "Play";
                mediterradio_text.Text = "Play";

                icat_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                icatronica_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                icatjazz_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                musicatles_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                mediterradio_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
            }
            else
            {
                totcat_text.Text = "Play";
                totcat_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                totcat.Pause();
            }
        }

        private void play_mediterradio_Click(object sender, RoutedEventArgs e)
        {
            if (mediterradio_text.Text.Equals("Play"))
            {
                mediterradio_text.Text = "Stop";
                mediterradio_image.Source = new BitmapImage(new Uri("Images\\pause.png", UriKind.RelativeOrAbsolute));
                mediterradio.Play();

                icat.Pause();
                icatronica.Pause();
                icatjazz.Pause();
                musicatles.Pause();
                totcat.Pause();

                icat_text.Text = "Play";
                icatronica_text.Text = "Play";
                icatjazz_text.Text = "Play";
                musicatles_text.Text = "Play";
                totcat_text.Text = "Play";

                icat_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                icatronica_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                icatjazz_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                musicatles_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                totcat_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                
            }
            else
            {
                mediterradio_text.Text = "Play";
                mediterradio_image.Source = new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                mediterradio.Pause();
            }
        }
        /*private void Slider_icat_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (icat != null)
                icat.Volume = (double)e.NewValue;
        }*/
    }
}