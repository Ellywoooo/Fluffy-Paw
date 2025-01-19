using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
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
    public sealed partial class Menu : Page
    {
        public Menu()
        {
            this.InitializeComponent();

            #region Setup the device sizing for the application  
            ApplicationView.GetForCurrentView().TryResizeView(new Size(App.DeviceScreenWidth, App.DeviceScreenHeight));
            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(App.DeviceMinimumScreenWidth, App.DeviceMinimumScreenHeight));
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            #endregion
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //Assgin the userId
            string UserId = (string)e.Parameter;

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
