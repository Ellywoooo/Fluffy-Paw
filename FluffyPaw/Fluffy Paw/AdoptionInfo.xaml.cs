using Fluffy_Paw.Models;
using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Fluffy_Paw
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdoptionInfo : Page
    {

        public AdoptionInfo()
        {
            this.InitializeComponent();
        }
        
   
        private void OnPropertyChanged(string v)
        {
            throw new NotImplementedException();
        }

        //Getting the parameter from Adoption page and bind it into the Gridview
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            //Check it the paramater was passed or not
            if (e.Parameter != null && e.Parameter is AdoptionList)
            {
                //Get the clicked item from the parameter
                var clickedItem = (AdoptionList)e.Parameter;

                //Create the new collcetion contains the clickeditem
                var clickedItemCollection = new ObservableCollection<AdoptionList>{ clickedItem };

                //Bind the Gridview with clickedItemCollection
                DetailGridView.ItemsSource = clickedItemCollection;
                
                //Set the clicked item as the Datacontext of the page
                this.DataContext = clickedItem;
            }
        }

        private void BackKey_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Adoption));
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
