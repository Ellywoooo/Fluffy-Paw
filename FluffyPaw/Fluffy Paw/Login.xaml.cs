using Fluffy_Paw.Models;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using System;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Fluffy_Paw
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Login : Page
    {
        private List<Users> users;
        public Login()
        {
            this.InitializeComponent();
            
        }


        private async void Loginbtn_Click(object sender, RoutedEventArgs e)
        {
            //If the userID or password box are empty or contains whitespace,
            if (string.IsNullOrWhiteSpace(Userid.Text) || string.IsNullOrWhiteSpace(Userpw.Password))
            {
                MessageDialog Fail1msg = new MessageDialog("Fill your ID and Password");
                await Fail1msg.ShowAsync();

                //Clear the textboxes
                Userid.Text = "";
                Userpw.Password = "";
            }

            else
            {

                //If login is a success, display message and move to main menu page
                if (Users.CheckLogin(Userid.Text, Userpw.Password) > 0 )
                {
           
                    MessageDialog Successmsg = new MessageDialog("Welcome " + Userid.Text + " !");
                    await Successmsg.ShowAsync();

                    Errormsg.Text = "";

                    Frame.Navigate(typeof(Menu), Userid.Text);
                }

                else
                {
                    //int check = Users.CheckLogin(Userid.Text, Userpw.Password);
                    //MessageDialog Successmsg = new MessageDialog(Convert.ToString(check));
                    //await Successmsg.ShowAsync();

                    Errormsg.Text = "The userID or password you entered is incorrect";
                    
                    //Clear the textboxes
                    Userid.Text = "";
                    Userpw.Password = "";
                }

               
            }
        }

        //Register button click 
        private void Regibtn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(Register));
        }

    }
}
