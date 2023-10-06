using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Interaction logic for Login_Page.xaml
    /// </summary>
    public partial class Login_Page : Window
    {
        Boolean isAuth = false;
        public Login_Page()
        {
            InitializeComponent();
            /*
            using (var db = new UserContext())
            {
                var user = new User { Name = "aa", Password = "bb" };
                db.Users.Add(user);
                db.SaveChanges();

                var query = from u in db.Users orderby u.Name select u;
            }

            using (var db = new UserContext())
            {
                var product = new Product { Qty=4, Name = "aa", Description = "bb" };
                db.Products.Add(product);
                db.SaveChanges();

                var query = from u in db.Products orderby u.Name select u;
            }
            
            */
        }

        public class User
        {
            public int UserId { get; set; }
            public string Name { get; set; }
            public string Password { get; set; }
        }
        public class Product
        {
            public int ProductId { get; set; }
            public string Name { get; set; }
            public int Qty { get; set; }
            public string Description { get; set; }
        }

        public class UserContext : DbContext
        {
            public DbSet<User> Users { get; set; }
            public DbSet<Product> Products { get; set; }
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new UserContext())
            {             
                var query = from u in db.Users orderby u.Name select u;
                foreach (var item in query)
                {
                    if(item.Name == userName.Text && item.Password == password.Text) isAuth = true;
                    //Console.WriteLine($"{item.Name}");
                }
            }

            if(isAuth)
            {
                this.Hide();
                Home_page home_Page = new Home_page();
                home_Page.Show();
                //MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }

        private void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {

            this.Hide();
            Register_Page register_Page = new Register_Page();
            register_Page.Show();
        }
    }
}
