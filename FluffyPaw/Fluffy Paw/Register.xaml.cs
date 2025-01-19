using Fluffy_Paw.Models;
using System;
using System.Collections.Generic;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Fluffy_Paw
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Register : Page
    {
        //Display the database into the list
        //private List<Users> users;
        public Register()
        {
            this.InitializeComponent();
            
            //users = Users.GetData();
            //Userlist.ItemsSource = users; 

        }

        private async void SignUpbtnClick(object sender, RoutedEventArgs e)
        {

            //When there is a empty textbox
            if (string.IsNullOrWhiteSpace(RName.Text) || string.IsNullOrWhiteSpace(REmail.Text)
                || string.IsNullOrWhiteSpace(RPassword.Password) || string.IsNullOrWhiteSpace(CPpassword.Password))
            {
                MessageDialog EmptyFailmsg = new MessageDialog("Please fill out all the forms");
                await EmptyFailmsg.ShowAsync();

                ClearText();
            }
            //When the all textboxes are filled
            else
            {
                //If the user ID is not in the database
                try
                {
                    //If password confirm does not match with password
                    if (!(RPassword.Password == CPpassword.Password))
                    {
                        MessageDialog PasswordFailmsg = new MessageDialog("Passwords do not match!");
                        await PasswordFailmsg.ShowAsync();

                        ClearText();

                    }
                    else
                    //Add the data into the database
                    {
                        Users.AddData(RName.Text, REmail.Text, RPassword.Password);

                        MessageDialog Successmsg = new MessageDialog("You have registered as a member!");
                        await Successmsg.ShowAsync();

                        ClearText();

                        //Go back to the login page
                        Frame.GoBack();
                    }

                }
                //If the user ID is already registerd in the database.
                catch (Exception)
                {
                    MessageDialog Failmsg = new MessageDialog("Your user ID is already in use!");
                    await Failmsg.ShowAsync();

                    ClearText();
                }
            }
    
        }

        //Clear the text in the textbox and passwordbox
        private void ClearText()
        {         
            RName.Text = "";
            REmail.Text = "";
            CPpassword.Password = "";
            RPassword.Password = "";
        }

        //Back to the login page
        private void Back_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }

 
}
