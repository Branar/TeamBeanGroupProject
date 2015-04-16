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
using System.Device.Location;

namespace PhoneApp1
{
    public partial class Geolocate : PhoneApplicationPage
    {
        public Geolocate()
        {
            InitializeComponent();
        }
        string latitude = "";
        string longitude = "";
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void ContentPanel_Loaded(object sender, RoutedEventArgs e)
        {
            GeoCoordinateWatcher watchGeo = new GeoCoordinateWatcher(GeoPositionAccuracy.High);
            watchGeo.MovementThreshold = 1.0;
            watchGeo.TryStart(false, TimeSpan.FromMilliseconds(1000));
            GeoCoordinate holdGeo = new GeoCoordinate();
            holdGeo = watchGeo.Position.Location;
            latitude = holdGeo.Latitude.ToString();
            longitude = holdGeo.Longitude.ToString();
            Uri holdAdUri = new Uri("https://www.google.co.uk/maps/place/" + latitude + "+" + longitude, UriKind.Absolute);
            webBrowserPathFind.Source = holdAdUri;
        }

    }
}