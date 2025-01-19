using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Services.Maps;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
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
    public sealed partial class Location : Page
    {
        MapControl TestMap2 = new MapControl();
        private string addressToGeocode;

        //Pin stream
        RandomAccessStreamReference mapIconStreamReference1;
        public Location()
        {
            this.InitializeComponent();

            TestMap2.ZoomInteractionMode = MapInteractionMode.GestureAndControl;
            TestMap2.TiltInteractionMode = MapInteractionMode.GestureAndControl;
            TestMap2.MapServiceToken = "h1bEzT5NsdVcnAumbtFn~g49bqDHwWhLRwq9csN1ePA~Au0p5uboCSquVGnwhrlwTljRlURvNCrf0BG-PZe_uVQKy2k0YXxI-EsgVlzkBjgb";

            //Push Pin image
            mapIconStreamReference1 = RandomAccessStreamReference.CreateFromUri(new Uri("ms-appx:///Assets/PinIcon.png"));

        }

        //Receive the specific location for Geocoding
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //Assgin the location into string addressToGeocode
            addressToGeocode = (string)e.Parameter;

        }
        private async void TestMap1_Loaded(object sender, RoutedEventArgs e)
        {
            //Map Icon variable
            MapIcon mapIcon1 = new MapIcon();
            
            // Geocode the specified address
            
            MapLocationFinderResult result = await MapLocationFinder.FindLocationsAsync(addressToGeocode, null, 1);

            // Set the start up possition to the poly
            TestMap1.Center = new Geopoint(new BasicGeoposition
            {
                Latitude = result.Locations[0].Point.Position.Latitude,
                Longitude = result.Locations[0].Point.Position.Longitude
            });


            mapIcon1.Location = TestMap1.Center;
            mapIcon1.NormalizedAnchorPoint = new Point(0.5, 1.0);
            mapIcon1.Title = "Point";

            mapIcon1.Image = mapIconStreamReference1;
            mapIcon1.ZIndex = 0;
            TestMap1.MapElements.Add(mapIcon1);

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
