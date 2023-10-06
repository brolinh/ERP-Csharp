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

namespace ERP_simple
{
    /// <summary>
    /// Interaction logic for Home_page.xaml
    /// </summary>
    public partial class Home_page : Window
    {
        public Home_page()
        {
            InitializeComponent();
        }

        private void Show_Product_Click(object sender, RoutedEventArgs e)
        {
            All_Product all_Product = new All_Product();
            all_Product.Show();
        }
        private void Add_Product_Click(object sender, RoutedEventArgs e)
        {
            Add_Product add_Product = new Add_Product();
            add_Product.Show();
        }
        private void Update_Product_Click(object sender, RoutedEventArgs e)
        {
            Edit_Product edit_Product = new Edit_Product();
            edit_Product.Show();
        }
    }
}
