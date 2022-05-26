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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            dgUsers.ItemsSource = KafeDBEntities1.GetContext().users.ToList();
            Manger.dgUser = dgUsers;
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3(null);
            window3.Show();
           
        }

        private void dgUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var selItem = dgUsers.SelectedItem as users;
            KafeDBEntities1.GetContext().users.Remove(selItem);
            KafeDBEntities1.GetContext().SaveChanges();
            Manger.dgUser.ItemsSource = KafeDBEntities1.GetContext().users.ToList();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3(dgUsers.SelectedItem as users);
            window3.Show();
        }
    }
}
