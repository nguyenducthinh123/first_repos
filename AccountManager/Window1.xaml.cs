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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            List<Item> items = new List<Item>();
            items.Add(new Item { Name = "Quản lí cơ sở dữ liệu thiên tai" });
            items.Add(new Item { Name = "Quản lý quy hoạch nước sạch và vệ sinh môi trường nông thôn" });
            items.Add(new Item { Name = "Quản lý thông tin về nước sạch và vệ sinh môi trường nông thôn" });
            items.Add(new Item
            {
                Name = "Báo cáo thống kê về CSDL nước sạch và vệ sinh môi trường"
            });
            items.Add(new Item { Name = "Quản lý Văn bản pháp luật về CSDL nước sạch và vệ sinh môi trường nông thôn" });
            listView.ItemsSource = items;
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to log out?", "Exit Confirmation", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }
    }
    public class Item
    {
        public string Name { get; set; }
    }
}
