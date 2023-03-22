using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AccountManager
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                lblStatus.Content = "Username is required.";
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Password))
            {
                lblStatus.Content = "Password is required.";
                return;
            }

            if (txtPassword.Password != txtConfirmPassword.Password)
            {
                lblStatus.Content = "Passwords do not match.";
                return;
            }

            // Code to create the account goes here

            lblStatus.Content = "Account created successfully.";
        }

        private void btnReturnLogin_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to return login page?", "Exit Confirmation", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }
    }
}
