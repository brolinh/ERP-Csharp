using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
    /// Interaction logic for All_Product.xaml
    /// </summary>
    public partial class All_Product : Window
    {
        public All_Product()
        {
            InitializeComponent();

            var productItemViewModel = new ProductItemViewModel();
            productItemViewModel.LoadProducts();
            this.DataContext = productItemViewModel;
        }

    }
    public class ProductItemViewModel
    {
        public ObservableCollection<ProductItem> dt { get; set; }
        public void LoadProducts()
        {
            dt = new ObservableCollection<ProductItem>();


            using (var db = new UserContext())
            {           
                var query = from p in db.Products orderby p.Name select p;

                foreach (var item in query)
                {
                    ProductItem Productitem = new ProductItem(item.Name, item.Qty.ToString(), item.Description);
                    dt.Add(Productitem);
                }
            }
        }

    }

    public class ProductItem
    {
        public ProductItem(string name, string qty, string description)
        {
            Name = name;
            Quantity = qty;
            Description = description;
        }
        public string Name { get; set; }
        public string Quantity { get; set; }
        public string Description { get; set; }
    }
}
