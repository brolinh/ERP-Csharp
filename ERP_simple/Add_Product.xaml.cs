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
using static ERP_simple.Login_Page;

namespace ERP_simple
{
    /// <summary>
    /// Interaction logic for Add_Product.xaml
    /// </summary>
    public partial class Add_Product : Window
    {
        public Add_Product()
        {
            InitializeComponent();
        }

        private void Add_Product_Item_Click(object sender, RoutedEventArgs e)
        {
            if (newProductName.Text == "" || Quantity.Text == "" || Description.Text=="")
            {
                AddMessage.Foreground = Brushes.Red;
                AddMessage.Content = "Enter full data";
                return;
            }
            AddMessage.Content = "";
            using (var db = new UserContext())
            {
                bool isAddOk = false;
                var query = from p in db.Products orderby p.Name select p;
                foreach (var item in query)
                {
                    if(item.Name == newProductName.Text)
                    {

                        AddMessage.Foreground = Brushes.Red;
                        AddMessage.Content = "Duplicate Product";
                        isAddOk = false;
                        break;
                    }
                    else
                    {
                        isAddOk = true;
                        AddMessage.Content = "";
                    }
                }

                if(isAddOk)
                {
                    var product = new Product { Qty = Convert.ToInt32(Quantity.Text), Name = newProductName.Text, Description = Description.Text };
                    db.Products.Add(product);
                    db.SaveChanges();
                    AddMessage.Content = "Successfully Added";
                    AddMessage.Foreground = Brushes.Green;
                }
            }
        }
    }
}
