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
using Microsoft.Phone.Shell;

namespace iCat.App
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

            icat_vol.Text = "85";
            icatronica_vol.Text = "85";
            icatjazz_vol.Text = "85";
            musicatles_vol.Text = "85";
            totcat_vol.Text = "85";
            mediterradio_vol.Text = "85";

            DateTime dt = DateTime.Now;

            icat_prog.Text = "Música i actualitat Cultural";
            if (dt.Hour.ToString().Equals("20") || dt.Hour.ToString().Equals("21") || dt.Hour.ToString().Equals("22") || dt.Hour.ToString().Equals("23") || dt.Hour.ToString().Equals("0") || dt.Hour.ToString().Equals("1") || dt.Hour.ToString().Equals("2") || dt.Hour.ToString().Equals("3") || dt.Hour.ToString().Equals("4") || dt.Hour.ToString().Equals("5") || dt.Hour.ToString().Equals("6") || dt.Hour.ToString().Equals("7")) { icat_prog.Text = "Selecció Musical iCat"; }
            if (!dt.DayOfWeek.ToString().Equals("Saturday") && !dt.DayOfWeek.ToString().Equals("Sunday")) if (dt.Hour.ToString().Equals("8")) { icat_prog.Text = "Els Experts"; }
            if (!dt.DayOfWeek.ToString().Equals("Saturday") && !dt.DayOfWeek.ToString().Equals("Sunday")) if (dt.Hour.ToString().Equals("20")) { icat_prog.Text = "Delicatessen"; }
            if (!dt.DayOfWeek.ToString().Equals("Saturday") && !dt.DayOfWeek.ToString().Equals("Sunday")) if (dt.Hour.ToString().Equals("21")) { icat_prog.Text = "Cabaret Elèctric"; }

            //icat_prog.Text = icat.CurrentState.ToString();

            //icat.Play();
            /*
            if (dt.DayOfWeek.ToString().Equals("Monday"))
            {
                if (dt.Hour.ToString().Equals("1") || dt.Hour.ToString().Equals("2") || dt.Hour.ToString().Equals("3") || dt.Hour.ToString().Equals("4") || dt.Hour.ToString().Equals("5") || dt.Hour.ToString().Equals("6") || dt.Hour.ToString().Equals("7")) { icat_prog.Text = "Selecció iCat"; }
                if (dt.Hour.ToString().Equals("8")) { icat_prog.Text = "Els Experts amb Albert Miralles i Roger Seró"; }
                if (dt.Hour.ToString().Equals("9") || dt.Hour.ToString().Equals("10") || dt.Hour.ToString().Equals("11")) { icat_prog.Text = "Música i actualitat Cultural amb Ajo Casals"; }
                if (dt.Hour.ToString().Equals("12") || dt.Hour.ToString().Equals("13") || dt.Hour.ToString().Equals("14") || dt.Hour.ToString().Equals("15")) { icat_prog.Text = "Música i actualitat Cultural amb Esther Duran"; }
                if (dt.Hour.ToString().Equals("16") || dt.Hour.ToString().Equals("17") || dt.Hour.ToString().Equals("18") || dt.Hour.ToString().Equals("19")) { icat_prog.Text = "Música i actualitat Cultural amb Francesc Marcet"; }
                if (dt.Hour.ToString().Equals("20")) { icat_prog.Text = "Delicatessen amb Albert Puig"; }
                if (dt.Hour.ToString().Equals("21")) { icat_prog.Text = "Cabaret Elèctric amb Montse Virgili"; }
                if (dt.Hour.ToString().Equals("22")) { icat_prog.Text = "Sona 9 amb Lluís Gendrau"; }
                if (dt.Hour.ToString().Equals("23") || dt.Hour.ToString().Equals("0")) { icat_prog.Text = "Nits de Jazz"; }
            }
            if (dt.DayOfWeek.ToString().Equals("Tuesday"))
            {
                if (dt.Hour.ToString().Equals("1") || dt.Hour.ToString().Equals("2") || dt.Hour.ToString().Equals("3") || dt.Hour.ToString().Equals("4") || dt.Hour.ToString().Equals("5") || dt.Hour.ToString().Equals("6") || dt.Hour.ToString().Equals("7")) { icat_prog.Text = "Selecció iCat"; }
                if (dt.Hour.ToString().Equals("8")) { icat_prog.Text = "Els Experts amb Albert Miralles i Roger Seró"; }
                if (dt.Hour.ToString().Equals("9") || dt.Hour.ToString().Equals("10") || dt.Hour.ToString().Equals("11")) { icat_prog.Text = "Música i actualitat Cultural amb Ajo Casals"; }
                if (dt.Hour.ToString().Equals("12") || dt.Hour.ToString().Equals("13") || dt.Hour.ToString().Equals("14") || dt.Hour.ToString().Equals("15")) { icat_prog.Text = "Música i actualitat Cultural amb Esther Duran"; }
                if (dt.Hour.ToString().Equals("16") || dt.Hour.ToString().Equals("17") || dt.Hour.ToString().Equals("18") || dt.Hour.ToString().Equals("19")) { icat_prog.Text = "Música i actualitat Cultural amb Francesc Marcet"; }
                if (dt.Hour.ToString().Equals("20")) { icat_prog.Text = "Delicatessen amb Albert Puig"; }
                if (dt.Hour.ToString().Equals("21")) { icat_prog.Text = "Cabaret Elèctric amb Montse Virgili"; }
                if (dt.Hour.ToString().Equals("22")) { icat_prog.Text = "iCatFolk amb Núria Balaguer"; }
                if (dt.Hour.ToString().Equals("23") || dt.Hour.ToString().Equals("0")) { icat_prog.Text = "Nits de Jazz"; }
            }
            if (dt.DayOfWeek.ToString().Equals("Wednesday"))
            {
                if (dt.Hour.ToString().Equals("1") || dt.Hour.ToString().Equals("2") || dt.Hour.ToString().Equals("3") || dt.Hour.ToString().Equals("4") || dt.Hour.ToString().Equals("5") || dt.Hour.ToString().Equals("6") || dt.Hour.ToString().Equals("7")) { icat_prog.Text = "Selecció iCat"; }
                if (dt.Hour.ToString().Equals("8")) { icat_prog.Text = "Els Experts amb Albert Miralles i Roger Seró"; }
                if (dt.Hour.ToString().Equals("9") || dt.Hour.ToString().Equals("10") || dt.Hour.ToString().Equals("11")) { icat_prog.Text = "Música i actualitat Cultural amb Ajo Casals"; }
                if (dt.Hour.ToString().Equals("12") || dt.Hour.ToString().Equals("13") || dt.Hour.ToString().Equals("14") || dt.Hour.ToString().Equals("15")) { icat_prog.Text = "Música i actualitat Cultural amb Esther Duran"; }
                if (dt.Hour.ToString().Equals("16") || dt.Hour.ToString().Equals("17") || dt.Hour.ToString().Equals("18") || dt.Hour.ToString().Equals("19")) { icat_prog.Text = "Música i actualitat Cultural amb Francesc Marcet"; }
                if (dt.Hour.ToString().Equals("20")) { icat_prog.Text = "Delicatessen amb Albert Puig"; }
                if (dt.Hour.ToString().Equals("21")) { icat_prog.Text = "Cabaret Elèctric amb Montse Virgili"; }
                if (dt.Hour.ToString().Equals("22")) { icat_prog.Text = "T'agrada el Blues? amb Quico Pi de la Serra"; }
                if (dt.Hour.ToString().Equals("23") || dt.Hour.ToString().Equals("0")) { icat_prog.Text = "Nits de Jazz"; }
            }
            if (dt.DayOfWeek.ToString().Equals("Thursday"))
            {
                if (dt.Hour.ToString().Equals("1") || dt.Hour.ToString().Equals("2") || dt.Hour.ToString().Equals("3") || dt.Hour.ToString().Equals("4") || dt.Hour.ToString().Equals("5") || dt.Hour.ToString().Equals("6") || dt.Hour.ToString().Equals("7")) { icat_prog.Text = "Selecció iCat"; }
                if (dt.Hour.ToString().Equals("8")) { icat_prog.Text = "Els Experts amb Albert Miralles i Roger Seró"; }
                if (dt.Hour.ToString().Equals("9") || dt.Hour.ToString().Equals("10") || dt.Hour.ToString().Equals("11")) { icat_prog.Text = "Música i actualitat Cultural amb Ajo Casals"; }
                if (dt.Hour.ToString().Equals("12") || dt.Hour.ToString().Equals("13") || dt.Hour.ToString().Equals("14") || dt.Hour.ToString().Equals("15")) { icat_prog.Text = "Música i actualitat Cultural amb Esther Duran"; }
                if (dt.Hour.ToString().Equals("16") || dt.Hour.ToString().Equals("17") || dt.Hour.ToString().Equals("18") || dt.Hour.ToString().Equals("19")) { icat_prog.Text = "Música i actualitat Cultural amb Francesc Marcet"; }
                if (dt.Hour.ToString().Equals("20")) { icat_prog.Text = "Delicatessen amb Albert Puig"; }
                if (dt.Hour.ToString().Equals("21")) { icat_prog.Text = "Cabaret Elèctric amb Montse Virgili"; }
                if (dt.Hour.ToString().Equals("22")) { icat_prog.Text = "Independents amb Josep Martín"; }
                if (dt.Hour.ToString().Equals("23") || dt.Hour.ToString().Equals("0")) { icat_prog.Text = "Nits de Jazz"; }
            }
            if (dt.DayOfWeek.ToString().Equals("Friday"))
            {
                if (dt.Hour.ToString().Equals("1") || dt.Hour.ToString().Equals("2") || dt.Hour.ToString().Equals("3") || dt.Hour.ToString().Equals("4") || dt.Hour.ToString().Equals("5") || dt.Hour.ToString().Equals("6") || dt.Hour.ToString().Equals("7")) { icat_prog.Text = "Selecció iCat"; }
                if (dt.Hour.ToString().Equals("8")) { icat_prog.Text = "Els Experts amb Albert Miralles i Roger Seró"; }
                if (dt.Hour.ToString().Equals("9") || dt.Hour.ToString().Equals("10") || dt.Hour.ToString().Equals("11")) { icat_prog.Text = "Música i actualitat Cultural amb Ajo Casals"; }
                if (dt.Hour.ToString().Equals("12") || dt.Hour.ToString().Equals("13") || dt.Hour.ToString().Equals("14") || dt.Hour.ToString().Equals("15")) { icat_prog.Text = "Música i actualitat Cultural amb Esther Duran"; }
                if (dt.Hour.ToString().Equals("16") || dt.Hour.ToString().Equals("17") || dt.Hour.ToString().Equals("18") || dt.Hour.ToString().Equals("19")) { icat_prog.Text = "Música i actualitat Cultural amb Francesc Marcet"; }
                if (dt.Hour.ToString().Equals("20")) { icat_prog.Text = "Delicatessen amb Albert Puig"; }
                if (dt.Hour.ToString().Equals("21")) { icat_prog.Text = "Cabaret Elèctric amb Montse Virgili"; }
                if (dt.Hour.ToString().Equals("22") || dt.Hour.ToString().Equals("23")) { icat_prog.Text = "Nits de Club"; }
                if (dt.Hour.ToString().Equals("0")) { icat_prog.Text = "Nits de Jazz"; }
            }
            if (dt.DayOfWeek.ToString().Equals("Saturday"))
            {
                if (dt.Hour.ToString().Equals("1") || dt.Hour.ToString().Equals("2") || dt.Hour.ToString().Equals("3") || dt.Hour.ToString().Equals("4") || dt.Hour.ToString().Equals("5") || dt.Hour.ToString().Equals("6") || dt.Hour.ToString().Equals("7")) { icat_prog.Text = "Selecció iCat"; }
                if (dt.Hour.ToString().Equals("14") || dt.Hour.ToString().Equals("15")) { icat_prog.Text = "Fórmula iCat FM amb Francesc Marcet"; }
                if (dt.Hour.ToString().Equals("8") || dt.Hour.ToString().Equals("9") || dt.Hour.ToString().Equals("10") || dt.Hour.ToString().Equals("11") || dt.Hour.ToString().Equals("12") || dt.Hour.ToString().Equals("13") || dt.Hour.ToString().Equals("16") || dt.Hour.ToString().Equals("17") || dt.Hour.ToString().Equals("18") || dt.Hour.ToString().Equals("19")) { icat_prog.Text = "Fórmula iCat FM amb Aran Mazuque"; }
                if (dt.Hour.ToString().Equals("20") || dt.Hour.ToString().Equals("21")) { icat_prog.Text = "Tarda Tardà amb Jordi Tardà"; }
                if (dt.Hour.ToString().Equals("22") || dt.Hour.ToString().Equals("23") || dt.Hour.ToString().Equals("0")) { icat_prog.Text = "Nits de Club"; }
            }
            if (dt.DayOfWeek.ToString().Equals("Sunday"))
            {
                if (dt.Hour.ToString().Equals("0")) { icat_prog.Text = "Nits de Club"; }
                if (dt.Hour.ToString().Equals("1") || dt.Hour.ToString().Equals("2") || dt.Hour.ToString().Equals("3") || dt.Hour.ToString().Equals("4") || dt.Hour.ToString().Equals("5") || dt.Hour.ToString().Equals("6") || dt.Hour.ToString().Equals("7")) { icat_prog.Text = "Selecció iCat"; }
                if (dt.Hour.ToString().Equals("14") || dt.Hour.ToString().Equals("15")) { icat_prog.Text = "Fórmula iCat FM amb Esther Duran"; }
                if (dt.Hour.ToString().Equals("8") || dt.Hour.ToString().Equals("9") || dt.Hour.ToString().Equals("10") || dt.Hour.ToString().Equals("11") || dt.Hour.ToString().Equals("12") || dt.Hour.ToString().Equals("13") || dt.Hour.ToString().Equals("16") || dt.Hour.ToString().Equals("17") || dt.Hour.ToString().Equals("18") || dt.Hour.ToString().Equals("19")) { icat_prog.Text = "Fórmula iCat FM amb Aran Mazuque"; }
                if (dt.Hour.ToString().Equals("20")) { icat_prog.Text = "Músiques Urbanes amb Pablo Larraguíbel"; }
                if (dt.Hour.ToString().Equals("21")) { icat_prog.Text = "iJazz Club amb David Talleda"; }
                if (dt.Hour.ToString().Equals("22") || dt.Hour.ToString().Equals("23") || dt.Hour.ToString().Equals("0")) { icat_prog.Text = "Nits de Jazz"; }
                
            }*/
            /*
            PhoneApplicationService.Current.ApplicationIdleDetectionMode = IdleDetectionMode.Disabled;
            PhoneApplicationFrame rootFrame = App.Current.RootVisual as PhoneApplicationFrame;
            if (rootFrame != null)
            {
                rootFrame.Obscured += new EventHandler<ObscuredEventArgs>(rootFrame_Obscured);
                rootFrame.Unobscured += new EventHandler(rootFrame_Unobscured);
            }*/
        }

        // Cargar datos para los elementos ViewModel
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void CarregaAudio(string canaliCat, TextBlock canal_text, MediaElement canal)
        {

            if (canal.CurrentState == MediaElementState.Opening)
            {
                while (canal.CurrentState != MediaElementState.Opening)
                {
                    //Juga a escacs - Montse dixit.
                }
            }

            //if (canal_text.Text.Equals("Play")) //Està en pausa
            if (canal.CurrentState == MediaElementState.Stopped || canal.CurrentState == MediaElementState.Paused) //Està en pausa
            {
                icat_text.Text = canaliCat.Equals("iCat") ? "Stop" : "Play";
                icatjazz_text.Text = canaliCat.Equals("iCatJazz") ? "Stop" : "Play";
                icatronica_text.Text = canaliCat.Equals("iCatronica") ? "Stop" : "Play";
                totcat_text.Text = canaliCat.Equals("totCat") ? "Stop" : "Play";
                musicatles_text.Text = canaliCat.Equals("iCatMon") ? "Stop" : "Play";
                mediterradio_text.Text = canaliCat.Equals("iCatRumba") ? "Stop" : "Play";

                icat_image.Source = canaliCat.Equals("iCat") ? new BitmapImage(new Uri("Images\\pause.png", UriKind.RelativeOrAbsolute)) : new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                icatjazz_image.Source = canaliCat.Equals("iCatJazz") ? new BitmapImage(new Uri("Images\\pause.png", UriKind.RelativeOrAbsolute)) : new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                icatronica_image.Source = canaliCat.Equals("iCatronica") ? new BitmapImage(new Uri("Images\\pause.png", UriKind.RelativeOrAbsolute)) : new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                totcat_image.Source = canaliCat.Equals("totCat") ? new BitmapImage(new Uri("Images\\pause.png", UriKind.RelativeOrAbsolute)) : new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                musicatles_image.Source = canaliCat.Equals("iCatMon") ? new BitmapImage(new Uri("Images\\pause.png", UriKind.RelativeOrAbsolute)) : new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));
                mediterradio_image.Source = canaliCat.Equals("iCatRumba") ? new BitmapImage(new Uri("Images\\pause.png", UriKind.RelativeOrAbsolute)) : new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute));

                if (canaliCat.Equals("iCat")) { icat.Play(); } else { icat.Stop(); }
                if (canaliCat.Equals("iCatJazz")) { icatjazz.Play(); } else { icatjazz.Pause(); }
                if (canaliCat.Equals("iCatronica")) { icatronica.Play(); } else { icatronica.Pause(); }
                if (canaliCat.Equals("totCat")) { totcat.Play(); } else { totcat.Pause(); }
                if (canaliCat.Equals("iCatMon")) { musicatles.Play(); } else { musicatles.Pause(); }
                if (canaliCat.Equals("iCatRumba")) { mediterradio.Play(); } else { mediterradio.Pause(); }
            }
            else //Està escoltant-se
            {
                icat_text.Text = canaliCat.Equals("iCat") ? "Play" : "Stop";
                icatjazz_text.Text = canaliCat.Equals("iCatJazz") ? "Play" : "Stop";
                icatronica_text.Text = canaliCat.Equals("iCatronica") ? "Play" : "Stop";
                totcat_text.Text = canaliCat.Equals("totCat") ? "Play" : "Stop";
                musicatles_text.Text = canaliCat.Equals("iCatMon") ? "Play" : "Stop";
                mediterradio_text.Text = canaliCat.Equals("iCatRumba") ? "Play" : "Stop";

                icat_image.Source = canaliCat.Equals("iCat") ? new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute)) : new BitmapImage(new Uri("Images\\pause.png", UriKind.RelativeOrAbsolute));
                icatjazz_image.Source = canaliCat.Equals("iCatJazz") ? new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute)) : new BitmapImage(new Uri("Images\\pause.png", UriKind.RelativeOrAbsolute));
                icatronica_image.Source = canaliCat.Equals("iCatronica") ? new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute)) : new BitmapImage(new Uri("Images\\pause.png", UriKind.RelativeOrAbsolute));
                totcat_image.Source = canaliCat.Equals("totCat") ? new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute)) : new BitmapImage(new Uri("Images\\pause.png", UriKind.RelativeOrAbsolute));
                musicatles_image.Source = canaliCat.Equals("iCatMon") ? new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute)) : new BitmapImage(new Uri("Images\\pause.png", UriKind.RelativeOrAbsolute));
                mediterradio_image.Source = canaliCat.Equals("iCatRumba") ? new BitmapImage(new Uri("Images\\play.png", UriKind.RelativeOrAbsolute)) : new BitmapImage(new Uri("Images\\pause.png", UriKind.RelativeOrAbsolute));

                if (canaliCat.Equals("iCat")) { icat.Pause(); }
                if (canaliCat.Equals("iCatJazz")) { icatjazz.Pause(); }
                if (canaliCat.Equals("iCatronica")) { icatronica.Pause(); }
                if (canaliCat.Equals("totCat")) { totcat.Pause(); }
                if (canaliCat.Equals("iCatMon")) { musicatles.Pause(); }
                if (canaliCat.Equals("iCatRumba")) { mediterradio.Pause(); }
            }
        }

        private void play_icat_Click(object sender, RoutedEventArgs e)
        {
            //CarregaAudio("iCat", icat_text, icat);
            if (icat.CurrentState == MediaElementState.Closed)
            {

                icat.Play();
            }

            if (icat_text.Text.Equals("Play"))
            {
                icat_text.Text = "Stop";
                icat_image.Source = new BitmapImage(new Uri("Images\\pause.png", UriKind.RelativeOrAbsolute));
                icat.Play();

                icatronica.Stop();
                icatjazz.Stop();
                musicatles.Stop();
                totcat.Stop();
                mediterradio.Stop();

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
            }
            else
            {
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
            }
            else
            {
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

        private void icat_MediaFailed(object sender, ExceptionRoutedEventArgs e)
        {
            //MessageBox.Show("Error al obrir l'streaming. Intenta-ho més tard.");
            MessageBox.Show("Error: " + e.ErrorException.Message.ToString());
        }

        private void Slider_icat_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (icat != null)
            {
                icat.Volume = (double)e.NewValue;
                icatronica.Volume = (double)e.NewValue;
                icatjazz.Volume = (double)e.NewValue;
                musicatles.Volume = (double)e.NewValue;
                totcat.Volume = (double)e.NewValue;
                mediterradio.Volume = (double)e.NewValue;

                double vol = (double)e.NewValue;
                vol = vol * 100;
                int volu = (int)vol;

                icat_vol.Text = volu.ToString();
                icatronica_vol.Text = volu.ToString();
                icatjazz_vol.Text = volu.ToString();
                musicatles_vol.Text = volu.ToString();
                totcat_vol.Text = volu.ToString();
                mediterradio_vol.Text = volu.ToString();
            }
        }

        private void icat_BufferingProgressChanged(object sender, RoutedEventArgs e)
        {
            //icat_carregant.Text = "Carregant Icat " + (icat.BufferingProgress * 100).ToString() + "% ...";
        }

        private void icat_CurrentStateChanged(object sender, RoutedEventArgs e)
        {
            //icat_carregant.Text = icat.CurrentState == MediaElementState.Buffering ? "Carregant Icat..." : icat.CurrentState.ToString();
            icat_carregant.Text = icat.CurrentState == MediaElementState.Buffering ? "Carregant Icat..." : "";
            icatronica_carregant.Text = icat.CurrentState == MediaElementState.Buffering ? "Carregant Icat..." : "";
            icatjazz_carregant.Text = icat.CurrentState == MediaElementState.Buffering ? "Carregant Icat..." : "";
            totcat_carregant.Text = icat.CurrentState == MediaElementState.Buffering ? "Carregant Icat..." : "";
            icatRumba_carregant.Text = icat.CurrentState == MediaElementState.Buffering ? "Carregant Icat..." : "";
        }

        private void icatronica_CurrentStateChanged(object sender, RoutedEventArgs e)
        {
            icat_carregant.Text = icat.CurrentState == MediaElementState.Buffering ? "Carregant Icatrònica..." : "";
            icatronica_carregant.Text = icat.CurrentState == MediaElementState.Buffering ? "Carregant Icatrònica..." : "";
            icatjazz_carregant.Text = icat.CurrentState == MediaElementState.Buffering ? "Carregant Icatrònica..." : "";
            totcat_carregant.Text = icat.CurrentState == MediaElementState.Buffering ? "Carregant Icatrònica..." : "";
            icatRumba_carregant.Text = icat.CurrentState == MediaElementState.Buffering ? "Carregant Icatrònica..." : "";
        }

        private void icatjazz_CurrentStateChanged(object sender, RoutedEventArgs e)
        {
            icat_carregant.Text = icat.CurrentState == MediaElementState.Buffering ? "Carregant Icat Jazz..." : "";
            icatronica_carregant.Text = icat.CurrentState == MediaElementState.Buffering ? "Carregant Icat Jazz..." : "";
            icatjazz_carregant.Text = icat.CurrentState == MediaElementState.Buffering ? "Carregant Icat Jazz..." : "";
            totcat_carregant.Text = icat.CurrentState == MediaElementState.Buffering ? "Carregant Icat Jazz..." : "";
            icatRumba_carregant.Text = icat.CurrentState == MediaElementState.Buffering ? "Carregant Icat Jazz..." : "";
        }

        private void icatMon_CurrentStateChanged(object sender, RoutedEventArgs e)
        {
            icat_carregant.Text = icat.CurrentState == MediaElementState.Buffering ? "Carregant Icat Món..." : "";
            icatronica_carregant.Text = icat.CurrentState == MediaElementState.Buffering ? "Carregant Icat Món..." : "";
            icatjazz_carregant.Text = icat.CurrentState == MediaElementState.Buffering ? "Carregant Icat Món..." : "";
            totcat_carregant.Text = icat.CurrentState == MediaElementState.Buffering ? "Carregant Icat Món..." : "";
            icatRumba_carregant.Text = icat.CurrentState == MediaElementState.Buffering ? "Carregant Icat Món..." : "";
        }

        private void toticat_CurrentStateChanged(object sender, RoutedEventArgs e)
        {
            icat_carregant.Text = icat.CurrentState == MediaElementState.Buffering ? "Carregant Tot Icat..." : "";
            icatronica_carregant.Text = icat.CurrentState == MediaElementState.Buffering ? "Carregant Tot Icat..." : "";
            icatjazz_carregant.Text = icat.CurrentState == MediaElementState.Buffering ? "Carregant Tot Icat..." : "";
            totcat_carregant.Text = icat.CurrentState == MediaElementState.Buffering ? "Carregant Tot Icat..." : "";
            icatRumba_carregant.Text = icat.CurrentState == MediaElementState.Buffering ? "Carregant Tot Icat..." : "";
        }

        private void icatRumba_CurrentStateChanged(object sender, RoutedEventArgs e)
        {
            icat_carregant.Text = icat.CurrentState == MediaElementState.Buffering ? "Carregant Icat Rumba..." : "";
            icatronica_carregant.Text = icat.CurrentState == MediaElementState.Buffering ? "Carregant Icat Rumba..." : "";
            icatjazz_carregant.Text = icat.CurrentState == MediaElementState.Buffering ? "Carregant Icat Rumba..." : "";
            totcat_carregant.Text = icat.CurrentState == MediaElementState.Buffering ? "Carregant Icat Rumba..." : "";
            icatRumba_carregant.Text = icat.CurrentState == MediaElementState.Buffering ? "Carregant Icat Rumba..." : "";
        }
    }
}