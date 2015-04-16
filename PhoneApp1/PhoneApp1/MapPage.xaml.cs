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
//Team Bean
//Windows Phone Application: Lincoln Points Of Interest

namespace PhoneApp1
{
    public partial class MapPage : PhoneApplicationPage
    {
        public MapPage()
        {
            InitializeComponent();
            
        }
        string holdAddress = "";
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void ContentPanel_Loaded(object sender, RoutedEventArgs e)
        {
            
            if (NavigationContext.QueryString.TryGetValue("holdAddress", out holdAddress))
            {
                //set up a url which contains a path to google maps with a search for the address of the searched place
                Uri holdAdUri = new Uri("https://www.google.co.uk/maps/place/" + holdAddress, UriKind.Absolute);
                //sets the uri to the value of the web source of the browser window
                webBrowser1.Source = holdAdUri;
            }
        }
    }
}