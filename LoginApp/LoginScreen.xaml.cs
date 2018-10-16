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

        private void Button_Click(object sender, RoutedEventArgs e)
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
                    MessageBox.Show("Main Menu, here we come!");
                    break;

                default:
                    // Do something default.
                    break;
            }
        }
    }
}
