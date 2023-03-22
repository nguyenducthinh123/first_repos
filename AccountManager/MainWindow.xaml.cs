using System;
using System.Windows;
using System.Windows.Controls;

namespace AccountManager
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_ClickCreate(object sender, RoutedEventArgs e)
        {
            Window2 window= new Window2();
            window.Show();
        }

        private void Button_ClickLogin(object sender, RoutedEventArgs e)
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

            // Code to validate the login credentials goes here

            string username = txtUsername.Text;
            string password = txtPassword.Password;

            // Xác thực đăng nhập tại đây
            if (username == "admin" && password == "1")
            {
               Window1 window1= new Window1();
               window1.Show();
                
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu. Vui lòng thử lại.");
            }

            lblStatus.Content = "Login successful.";

        }

        private void Button_ClickForgotPassword(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                lblStatus.Content = "Username is required.";
                return;
            }

            // Code to handle the forgotten password goes here

            lblStatus.Content = "Password reset instructions have been sent to your email.";
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to exit and close application ?", "Exit Confirmation", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }
    }
}
