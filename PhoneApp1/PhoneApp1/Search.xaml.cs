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
    public partial class Search : PhoneApplicationPage
    {
        public string address = "",locationName = "", phoneNum = "", email= "", openingTime = "", closingTime = "", category = "";
        public Search()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void hyperlinkButton1_Click(object sender, RoutedEventArgs e)
        {
            string inputString = textBox1.Text;
            inputString = inputString.ToLower(); //converts the text input into the textbox into lower case letters 

            if (inputString == "") //checks if the text box is empty and returns a message in the textblock.
            {
                feedbackBox.Text = "You must enter a location in order to search!";
            }
            if (inputString == "lincoln castle")
            {
                
                locationName = "Lincoln Castle";
                address = "Castle Hill, Lincoln, LN1 3AA";
                phoneNum = "01522 782040";
                email = "groups-lincolncastle@lincolnshire.gov.uk";
                openingTime = "10:00am";
                closingTime = "4:00pm";
                category = "Historical";
            }
            else if (inputString == "lincoln cathedral")
            {
                locationName = "Lincoln Cathedral";
                address = "Minster Yard, Lincoln, LN2 1PX";
                phoneNum = "01522 561600";
                email = "visitors@lincolncathedral.com";
                openingTime = "7:15am";
                closingTime = "6:00pm";
                category = "Historical";
            }
            else if (inputString == "arboretum")
            {
                locationName = "Arboretum";
                address = "City Hall, Beaumont Fee Lincoln, LN1 1DD";
                phoneNum = "01522 881188";
                email = "urbanrangers@lincoln.gov.uk";
                openingTime = "7:00am";
                closingTime = "10:00pm";
                category = "Park";
            }
            else if (inputString == "newport arch")
            {
                locationName = "Newport Arch";
                address = "50 Bailgate, Lincoln, LN1 3AP";
                phoneNum = "";
                email = "";
                openingTime = "24 hours";
                closingTime = "";
                category = "Historical";
            }
            else if (inputString == "the collection")
            {
                locationName = "The Collection";
                address = "Carholme Road, Lincoln, LN1 1SE";
                phoneNum = "01522 782040";
                email = "thecollection@lincolnshire.gov.uk";
                openingTime = "10:00am";
                closingTime = "4:00pm";
                category = "Museum";
            }
            else if (inputString == "lincoln racecourse")
            {
                locationName = "Lincoln Racecourse";
                address = "Danes Terrace, Lincoln, LN2 1LP";
                phoneNum = "01522 873502";
                email = "";
                openingTime = "";
                closingTime = "";
                category = "Sport";
            }
            else if ((inputString == "lincoln city f.c") || (inputString == "lincoln city fc"))
            {
                locationName = "Lincoln City F.C";
                address = "Ashby Avenue, Lincoln, LN6 0DY";
                phoneNum = "01522 880008";
                email = "LCFC@lincolncityfootballclub.com";
                openingTime = "";
                closingTime = "";
                category = "Sport";
            }
            else if (inputString == "museum of lincolnshire life")
            {
                locationName = "Museum of Lincolnshire Life";
                address = "Old Barracks, Burton Road, Lincoln, LN1 3LY";
                phoneNum = "01522 782040";
                email = "lincolnshirelife_museum@lincolnshire.gov.uk";
                openingTime = "10:00am";
                closingTime = "4:00pm";
                category = "Museum";
            }

            else if (inputString == "jews house")
            {
                locationName = "Jews House";
                address = "15 The Strait, Lincoln, LN2 1JD";
                phoneNum = "01522 524851";
                email = "info@jewshouserestaurant.co.uk";
                openingTime = "7.00am";
                closingTime = "9:30pm";
                category = "Restaurant, Historical";
            }
            else if ((inputString == "waterside") || (inputString == "waterside shopping centre"))
            {
                locationName = "Waterside Shopping centre";
                address = "High Street, Lincoln, LN2 2PG";
                phoneNum = "01522 529566";
                email = "info@watersideshopping.com";
                openingTime = "9:00am";
                closingTime = "5:30pm";
                category = "Shopping";
            }
            else if (inputString == "st marks shopping center")
            {
                locationName = "St Marks Shopping Center";
                address = "Management Suite, 1 Saint Marks Square, Lincoln, LN5 7EX";
                phoneNum = "01522 575240";
                email = "";
                openingTime = "9:00am";
                closingTime = "5:30pm";
                category = "Shopping";
            }
            else if (inputString == "theatre royal")
            {
                locationName = "Theatre Royal";
                address = "Clasketgate, Lincoln, LN2 1JJ";
                phoneNum = "01522 519999";
                email = "boxoffice@lincolntheatreroyal.com";
                openingTime = "10:00am";
                closingTime = "6:00pm";
                category = "Theatre";
            }
            else if (inputString == "drill hall")
            {
                locationName = "Drill Hall";
                address = "Free School Lane, Lincoln, LN2 1EY";
                phoneNum = "01522 873894";
                email = "boxoffice@lincolndrillhall.com";
                openingTime = "9:00am";
                closingTime = "5:00pm";
                category = "Theatre";
            }
            else if (inputString == "engine shed")
            {
                locationName = "Engine Shed";
                address = "University of Lincoln, Brayford Pool, Lincoln, LN6 7TS";
                phoneNum = "01522 837400";
                email = "hellothere@engineshed.co.uk";
                openingTime = "10:00am";
                closingTime = "4:00pm";
                category = "Music, Entertainment";
            }
            else if ((inputString == "university of lincoln") || (inputString == "uol"))
            {
                locationName = "University of Lincoln";
                address = "University of Lincoln, Brayford Pool, Lincoln, LN6 7TS";
                phoneNum = "01522 882000";
                email = "helpdesk@lincoln.ac.uk";
                openingTime = "9:00am";
                closingTime = "5:00pm";
                category = "Education";
            }
            else if (inputString == "lincoln college")
            {
                locationName = "Lincoln College";
                address = "Monks Road, Lincoln, LN2 5HQ";
                phoneNum = "01522 876000";
                email = "enquiries@lincolncollege.ac.uk";
                openingTime = "9:00am";
                closingTime = "5:00pm";
                category = "Education";
            }
            else if ((inputString == "bishop grosseteste university") || (inputString == "bgu"))
            {
                locationName = "Bishop Grosseteste University";
                address = "Longdales Road, Lincoln, LN1 3DY";
                phoneNum = "01522 527347";
                email = "reception@bishopg.ac.uk";
                openingTime = "9:00am";
                closingTime = "5:00pm";
                category = "Education";
            }
            else if (inputString == "hartsholme park")
            {
                locationName = "Hartsholme Park";
                address = "Skellingthorpe Road, Lincoln, LN6 0EY";
                phoneNum = "";
                email = "customer.services@lincoln.gov.uk";
                openingTime = "24 hours";
                closingTime = "";
                category = "Parks";
            }
            else if (inputString == "boultham park")
            {
                locationName = "Boultham Park";
                address = "Boultham Park, Lincoln";
                phoneNum = "01522 503180";
                email = "chelsey.barnes@linkage.org.uk";
                openingTime = "24 hours";
                closingTime = "";
                category = "Park, Historical";
            }
            else if (inputString == "west common")
            {
                locationName = "West Common";
                address = "West Common, Lincoln";
                phoneNum = "";
                email = "customer.services@lincoln.gov.uk";
                openingTime = "24 hours";
                closingTime = "";
                category = "Park";
            }
            else if (inputString == "south common")
            {
                locationName = "South Common";
                address = "South Common, Lincoln";
                phoneNum = "";
                email = "customer.services@lincoln.gov.uk";
                openingTime = "24 hours";
                closingTime = "";
                category = "Parks";
            }
            else if (inputString == "canwick park golf club")
            {
                locationName = "Canwick Park Golf Club";
                address = "Washingborough Road, Lincoln, LN4 1EF";
                phoneNum = "01522 542912";
                email = "manager@canwickpark.co.uk";
                openingTime = "";
                closingTime = "";
                category = "Sport";
            }
            else if (inputString == "carholme golf club")
            {
                locationName = "Carlholme Golf Club";
                address = "Carholme Road, Lincoln, LN1 1SE";
                phoneNum = "01522 523725";
                email = "";
                openingTime = "";
                closingTime = "";
                category = "Sport";
            }
            else if (inputString == "brayford boat trips")
            {
                locationName = "Brayford Boat Trips";
                address = "Brayford Wharf North, Lincoln, LN1 1YT";
                phoneNum = "01522 881200";
                email = "paul@lincolnboattrips.com";
                openingTime = "11:00am";
                closingTime = "3:45pm";
                category = "Tour";
            }
            else if (inputString == "tour bus")
            {
                locationName = "Tour Bus";
                address = "Minster Yard, Lincoln, LN2 1PX";
                phoneNum = "";
                email = "visitorinformation@lincolnbig.co.uk";
                openingTime = "10:00am";
                closingTime = "3:00pm";
                category = "Tour";
            }
            else if (inputString == "calder farm stables")
            {
                locationName = "Calder Farm Stables";
                address = "Calder Rd, Lincoln, LN5 9BB";
                phoneNum = "01522 851852";
                email = "";
                openingTime = "9:00pm";
                closingTime = "4:00pm";
                category = "Sport";
            }
            else if (inputString == "david lloyd")
            {
                locationName = "David Lloyd";
                address = "Burton Waters, Lincoln, LN1 2BE";
                phoneNum = "0345 129 6802";
                email = "";
                openingTime = "6:30am";
                closingTime = "11:00pm";
                category = "Gym";
            }
            else if (inputString == "doddington hall")
            {
                locationName = "Doddington Hall";
                address = "Doddington, Lincolnshire, LN6 4RU";
                phoneNum = "01522 694308";
                email = "info@doddingtonhall.com";
                openingTime = "11:00am";
                closingTime = "4:00pm";
                category = "Historical";
            }
            else if (inputString == "essential ayurveda retreats")
            {
                locationName = "Essential Ayurveda Retreats";
                address = "The Old Plough, 10 - 12 Fen Road, Lincolnshire, PE23 5PF";
                phoneNum = "01754 830559";
                email = "info@essentialayurveda.co.uk";
                openingTime = "";
                closingTime = "";
                category = "Spa";
            }
            else if (inputString == "gridline racing")
            {
                locationName = "Gridline Racing";
                address = "Dunford Road, Lincoln, LN5 8HF";
                phoneNum = "01522 539915";
                email = "info@gridlineracing.com";
                openingTime = "";
                closingTime = "";
                category = "Sport";
            }
            else if (inputString == "lincoln guided tours")
            {
                locationName = "Lincoln Guided Tours";
                address = "Address changes dependant on tour location";
                phoneNum = "01522 521256";
                email = "brian@lincolnguidedtours.co.uk";
                openingTime = "11:00am";
                closingTime = "5:30pm";
                category = "Tour";
            }
            else if (inputString == "jews court")
            {
                locationName = "Jews Court";
                address = "Steep Hill, Lincoln, LN2 1LS";
                phoneNum = "";
                email = "info@slha.org.uk";
                openingTime = "10:00am";
                closingTime = "4:00pm";
                category = "Historical";
            }
            else //this statement is called to display information in the textblock if the input text cant be matched to a statement
            {
                feedbackBox.Text = "Please check the name and spelling of your location!";
            }
            NavigationService.Navigate(new Uri("/PhoneApp1;component/InformationPage.xaml?" + "address=" + address + "&locationName=" + locationName + "&phoneNum=" + phoneNum + "&email=" + email + "&openingTime=" + openingTime + "&closingTime=" + closingTime + "&category=" + category, UriKind.Relative));
        }

    }
}
//PhoneApp1;component/InformationPage.xaml?address=address&locationName=locationName&phoneNum=phoneNum&email=email&openingTime=openingTime&closingTime=closingTime&category=category