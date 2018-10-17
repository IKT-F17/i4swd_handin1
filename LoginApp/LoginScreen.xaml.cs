using System.Collections.Generic;
using System.Windows;
using AppLogic;

namespace LoginApp
{
    public partial class LoginScreen : Window
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnLoginAsUser_Click(object sender, RoutedEventArgs e)
        {
            var userInput = new Dictionary<string, string>
            {
                { txtUsername.Text, txtPassword.Password }
            };

            var view = new AppCalls().ValidateInput(ref userInput);

            switch (view)
            {
                case 0:
                    // Switch to error screen, this could be showing error message that user and/or password does not exist.
                    MessageBox.Show("User and/or password was not in the database!");
                    break;

                case 1:
                    // Switch to Main Menu.
                    Hide();
                    new MainMenu().Show();
                    break;

                default:
                    // Do something default.
                    break;
            }
        }

        private void btnLoginAsGuest_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Logging in as Guest...");
        }

        private void btnRegisterUser_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Showing register user screen!");
        }

        private void txtUsername_GotFocus(object sender, RoutedEventArgs e)
        {
            txtUsername.SelectAll();
        }

        private void txtPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            txtPassword.Password = "";
        }
    }
}
