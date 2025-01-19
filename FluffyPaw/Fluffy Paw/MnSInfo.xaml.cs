using Fluffy_Paw.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Fluffy_Paw
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MnSInfo : Page
    {
        //Store the location for sending to the location page
        private string location;
        public MnSInfo()
        {
            this.InitializeComponent();
        }


        //Getting the parameter from Adoption page and bind it into the Gridview
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            //Check it the paramater was passed or not
            if (e.Parameter != null && e.Parameter is MnSList)
            {
                //Get the clicked item from the parameter
                var clickedItem = (MnSList)e.Parameter;

                //Create the new collcetion contains the clickeditem
                var clickedItemList = new List <MnSList> { clickedItem };

                //Bind the Gridview with clickedItemCollection
                DetailGridView.ItemsSource = clickedItemList;

                //Store the clickedItem of location
                location = clickedItem.Location; 
            }
        }

        private void LocationbtnClick(object sender, RoutedEventArgs e)
        {
            //Move the page with clickedItem of location
            Frame.Navigate(typeof(Location),location);
        }
        private void BackKey_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.GoBack();
        }
        private void Home_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Menu));
        }

        private void Adoption_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Adoption));
        }
        private void MnS_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(MissingandSighting));
        }
        private void Donation_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Donation));
        }
    }
}
