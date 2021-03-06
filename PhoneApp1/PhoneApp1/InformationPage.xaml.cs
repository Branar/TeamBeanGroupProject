﻿using System;
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
    public partial class InformationPage : PhoneApplicationPage
    {
        public InformationPage()
        {
            InitializeComponent();
        }
            string address = "";
            string locationName = "";
            string phoneNum = "";
            string email = "";
            string openingTime = "";
            string closingTime = "";
            string category = "";
       
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MapPage.xaml?holdAddress=" + address, UriKind.Relative));
        }

        private void ContentPanel_Loaded(object sender, RoutedEventArgs e)
        {

            //each if attempts to find the passed in variable value and saves it to the appropriate local variable, 
            //if its not found then the values are just left blank (Avoids a not found error)
            //they then set the variables to each appropriate text block
            if (NavigationContext.QueryString.TryGetValue("address", out address))
            {
                textBlock1.Text = string.Format("Address: {0}", address);
            }
            if (NavigationContext.QueryString.TryGetValue("locationName", out locationName))
            {
                PageTitle.Text = string.Format("{0}", locationName);
            }
            if (NavigationContext.QueryString.TryGetValue("phoneNum", out phoneNum))
            {
                textBlock2.Text = string.Format("Phone: {0}", phoneNum);
            }
            if (NavigationContext.QueryString.TryGetValue("email", out email))
            {
                textBlock3.Text = string.Format("Email: {0}", email);
            }
            if (NavigationContext.QueryString.TryGetValue("openingTime", out openingTime))
            {
                textBlock4.Text = string.Format("Open: {0}", openingTime);
            }
            if (NavigationContext.QueryString.TryGetValue("closingTime", out closingTime))
            {
                textBlock5.Text = string.Format("Close: {0}", closingTime);
            }
            if (NavigationContext.QueryString.TryGetValue("category", out category))
            {
                textBlock6.Text = string.Format("Category: {0}", category);
            }

        }
    }
}
