using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class Donation : Page
    {
        public Donation()
        {
            this.InitializeComponent();
        }
        
        private void DbtnClick(object sender, RoutedEventArgs e)
        {
            

            if (string.IsNullOrEmpty(Dname.Text))
            {
                var msgName = new MessageDialog("Please fill your name");
                msgName.ShowAsync();

            }

            else if (string.IsNullOrEmpty(Daddress.Text))
            {
                var msgAddress = new MessageDialog("Please fill your Address");
                msgAddress.ShowAsync();
            }
           
            else if (string.IsNullOrEmpty(Dphone.Text))
            {
                var msgPhone = new MessageDialog("Please fill your phone number");
                msgPhone.ShowAsync();
            }


            else if (string.IsNullOrEmpty(Demail.Text))
            {
                var msgEmail = new MessageDialog("Please fill your Email");
                msgEmail.ShowAsync();
            }

            else if (Dcombo.SelectedItem == null)
            {
                var msgPayment = new MessageDialog("Please choose the payment option");
                msgPayment.ShowAsync();
            }

            //If the user filled all info, then the message will display depending on the payment option
            else
            {
                //If the user select the Credit card payment option
                if(Dcombo.SelectedItem == "Credit card donation over the phone")
                {
                    var creditMsg = new MessageDialog("Thanks for your support! \n " +
                        "Credit card donations can be made over the phone by calling us on 07 123 3456", "Donation confirmed");
                    
                    creditMsg.ShowAsync();

                    ClearText();

                }

                //If the user select the bank transfer payment option
                else
                {
                    var bankMsg = new MessageDialog("Thanks for your support! \n\n " +
                     "You can transfer money directly to Fulffy Paw through your bank to:\n" +
                     "Acc. Name : Fluffy Paw\nAcc.Number : 12-3456-7890123-45", "Donation confirmed");

                    bankMsg.ShowAsync();

                    ClearText();
                }

            }


        }

        private void ClearText()
        {
            Dname.Text = "";
            Daddress.Text = "";
            Dphone.Text = "";
            Demail.Text = "";
            Dcombo.SelectedItem = null;
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
