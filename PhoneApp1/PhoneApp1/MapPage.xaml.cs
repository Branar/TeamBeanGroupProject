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

namespace PhoneApp1
{
    public partial class MapPage : PhoneApplicationPage
    {
        public MapPage()
        {
            InitializeComponent();
            
        }
        
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void ContentPanel_Loaded(object sender, RoutedEventArgs e)
        {
            string holdAddress = "";
            if (NavigationContext.QueryString.TryGetValue("holdAddress", out holdAddress))
            {
                Uri holdAdUri = new Uri("https://www.google.co.uk/maps/place/" + holdAddress, UriKind.Absolute);
                webBrowser1.Source = holdAdUri;
            }
        }
    }
}