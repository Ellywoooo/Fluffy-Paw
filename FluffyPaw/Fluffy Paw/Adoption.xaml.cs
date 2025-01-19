using Fluffy_Paw.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Fluffy_Paw
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>

    public sealed partial class Adoption : Page
    {
        
        public Adoption()
        {
            this.InitializeComponent();
       
        }


        /// Combobox itme selection
        private void ComboBoxSelection(Object sender, SelectionChangedEventArgs e)
        {
            if (AdoptCombo.SelectedItem is ComboBoxItem selectedItem)
            {
                string selectedAnimal = selectedItem.Content.ToString();
                
                SortItems(selectedAnimal);
    
            }
        }

        //Display the sorted items into the gridview 
        private void SortItems(string sortBy)
        {
            //Initialising ViewAdoptionList data to viewModel
            var viewModel = DataContext as ViewAdoptionList;

            //Get the filtered collection by comboboxitem
            var SortedItems = new ObservableCollection<AdoptionList>(viewModel.Items.Where(item => item.Animal == sortBy));

            //Bind the Gridview item with SortedItems
            AdoptionGridView.ItemsSource = SortedItems;
        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Initialising clicked item 
            var clickedItem = e.ClickedItem;

            Frame.Navigate(typeof(AdoptionInfo), clickedItem);
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
