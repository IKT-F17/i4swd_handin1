using System.Windows;

namespace LoginApp
{
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Game is starting...");
        }

        private void btnHighscore_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Showing Highscore screen...");
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            new LoginScreen().Show();
        }
    }
}
