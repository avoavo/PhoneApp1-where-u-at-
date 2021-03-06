﻿using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp1.Resources;
using System.IO.IsolatedStorage;
using System.Runtime.Serialization.Json;

namespace PhoneApp1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();

        }
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            if (IsolatedStorageSettings.ApplicationSettings.Contains("LocationConsent"))
            {
                // User has opted in or out of Location
                return;
            }
            else
            {
                MessageBoxResult result =
                    MessageBox.Show("This app accesses your phone's location. Is that ok?",
                    "Location",
                    MessageBoxButton.OKCancel);

                if (result == MessageBoxResult.OK)
                {
                    IsolatedStorageSettings.ApplicationSettings["LocationConsent"] = true;
                }
                else
                {
                    IsolatedStorageSettings.ApplicationSettings["LocationConsent"] = false;
                }

                IsolatedStorageSettings.ApplicationSettings.Save();
            }
        }


        //private async void OneShotLocation_Click(object sender, RoutedEventArgs e)
        //{

        //    if ((bool)IsolatedStorageSettings.ApplicationSettings["LocationConsent"] != true)
        //    {
        //        // The user has opted out of Location.
        //        return;
        //    }

        //    Geolocator geolocator = new Geolocator();
        //    geolocator.DesiredAccuracyInMeters = 50;

        //    try
        //    {
        //        Geoposition geoposition = await geolocator.GetGeopositionAsync(
        //            maximumAge: TimeSpan.FromMinutes(5),
        //            timeout: TimeSpan.FromSeconds(10)
        //            );

        //        LatitudeTextBlock.Text = geoposition.Coordinate.Latitude.ToString();
        //        LongitudeTextBlock.Text = geoposition.Coordinate.Longitude.ToString();
        //    }
        //    catch (Exception ex)
        //    {
        //        if ((uint)ex.HResult == 0x80004004)
        //        {
        //            // the application does not have the right capability or the location master switch is off
        //            StatusTextBlock.Text = "location  is disabled in phone settings.";
        //        }
        //        //else
        //        {
        //            // something else happened acquring the location
        //        }
        //    }
        //}



        //private async void OneShotLocation_Click(object sender, RoutedEventArgs e)
        private async void Tap(object sender, RoutedEventArgs e)
        {

            if ((bool)IsolatedStorageSettings.ApplicationSettings["LocationConsent"] != true)
            {
                // The user has opted out of Location.
                return;
            }

            Geolocator geolocator = new Geolocator();
            geolocator.DesiredAccuracyInMeters = 50;

            try
            {
                Geoposition geoposition = await geolocator.GetGeopositionAsync(
                    maximumAge: TimeSpan.FromMinutes(5),
                    timeout: TimeSpan.FromSeconds(10)
                    );

                LatitudeTextBlock.Text = geoposition.Coordinate.Latitude.ToString("0.00");
                LongitudeTextBlock.Text = geoposition.Coordinate.Longitude.ToString("0.00");

            }
            catch (Exception ex)
            {
                if ((uint)ex.HResult == 0x80004004)
                {
                    // the application does not have the right capability or the location master switch is off
                    StatusTextBlock.Text = "location  is disabled in phone settings.";
                }
                //else
                {
                    // something else happened acquring the location
                }
            }
        }





        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}