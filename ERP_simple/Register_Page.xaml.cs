using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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
using System.Xml.Linq;
using static ERP_simple.Login_Page;

namespace ERP_simple
{
    /// <summary>
    /// Interaction logic for Register_Page.xaml
    /// </summary>
    public partial class Register_Page : Window
    {
        public Register_Page()
        {
            InitializeComponent();
        }
        private void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {

            Boolean duplicate = false;
            if (newPassword.Text != newConfirmPassword.Text)
            {
                errorShowMessage.Content ="Password is incorrect";
                newPassword.Text = "";
                newConfirmPassword.Text = "";

                return;
            }
            using (var db = new UserContext())
            {
                var query = from u in db.Users orderby u.Name select u;
                foreach (var item in query)
                {
                    if (item.Name == newUserName.Text && item.Password == newPassword.Text) duplicate = true;
                    //Console.WriteLine($"{item.Name}");
                }
            }

            if (!duplicate)
            {
                this.Close();

                using (var db = new UserContext())
                {
                    var user = new User { Name = newUserName.Text, Password = newPassword.Text };
                    db.Users.Add(user);
                    db.SaveChanges();
                }
                Login_Page login_page = new Login_Page();
                login_page.Show();
            }
            else
            {
                MessageBox.Show("Duplicate user\nEnter another information");
            }
        }
    }
}
