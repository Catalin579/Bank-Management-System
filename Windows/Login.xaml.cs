using System.Windows;

namespace Bank_Management_System
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e) => Close();
        private void MinimizeButton_Click(object sender, RoutedEventArgs e) => WindowState = WindowState.Minimized;

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
