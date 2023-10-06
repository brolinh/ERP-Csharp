using ERP_simple.Migrations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static ERP_simple.Login_Page;

namespace ERP_simple
{
    /// <summary>
    /// Interaction logic for Edit_Product.xaml
    /// </summary>
    public partial class Edit_Product : Window
    {

        ProductItemViewModel productItemViewModel = new ProductItemViewModel();
        public Edit_Product()
        {
            InitializeComponent();

            productItemViewModel.LoadProducts();
            this.DataContext = productItemViewModel;
        }

        private void ListViewItem_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var item = sender as ListViewItem;
            if (item != null && item.IsSelected)
            {
            }
        }

        string selectedName = "";
        private void MySelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListView lv = sender as ListView;
            ProductItem item = lv.SelectedItem as ProductItem;
            UpdateName.Text = item.Name;
            UpdateQuantity.Text = item.Quantity;
            UpdateDescription.Text = item.Description;


            selectedName = item.Name;

        }
        private void DeleteProductBtn_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new UserContext())
            {
                var report = (from d in db.Products
                              where d.Name == selectedName
                              select d).Single();

                //selectedName = "";
                db.Products.Remove(report);
                db.SaveChanges();


            }
        }

        private void UpdateProductBtn_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new UserContext())
            {
                var report = (from d in db.Products
                              where d.Name == selectedName
                              select d).Single();
                //selectedName = UpdateName.Text;
                db.Products.Remove(report); 

                var product2 = new Login_Page.Product { Qty = Convert.ToInt32(UpdateQuantity.Text), Name = UpdateName.Text, Description = UpdateDescription.Text };
                db.Products.Add(product2);

                db.SaveChanges();

            }
        }
    }

}
