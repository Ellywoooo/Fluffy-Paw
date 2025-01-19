using Fluffy_Paw.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class MissingandSighting : Page
    {
        //Create mnslist to get the list from GetLists();
        private List<MnSList> mnslist;
        public MissingandSighting()
        {
            this.InitializeComponent();

            //Get the items from GetLists();
;           mnslist = MnSBoard.GetLists();
            
            //Set the data of mnslist to gridview itemsource
            MnSGridView.ItemsSource = mnslist;
        }


        // Combobox itme selection
        private void ComboBoxSelection(Object sender, SelectionChangedEventArgs e)
        {
            if (MnSCombo.SelectedItem is ComboBoxItem selectedItem)
            {
                string MS = selectedItem.Content.ToString();

                SortItems(MS);

            }
        }

        //Display the sorted items into the gridview 
        private void SortItems(string sortBy)
        {
            //Get the filtered collection by comboboxitem
            var SortedItems = mnslist.Where(animal => animal.MorS == sortBy);

            //Bind the Gridview item with SortedItems
            MnSGridView.ItemsSource = SortedItems;
        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Initialising clicked item 
            var clickedItem = e.ClickedItem;

            Frame.Navigate(typeof(MnSInfo), clickedItem);
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
