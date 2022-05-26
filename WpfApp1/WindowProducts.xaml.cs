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
    /// Логика взаимодействия для WindowProducts.xaml
    /// </summary>
    public partial class WindowProducts : Window
    {

        public WindowProducts()
        {
            InitializeComponent();
            dgProducts1.ItemsSource = KafeDBEntities1.GetContext().products.ToList();
            Manger.dgProducts = dgProducts1;
        }

       

        

        private void btnProducts_Click(object sender, RoutedEventArgs e)
        {
            NewProduct window7 = new NewProduct(null);
            window7.Show();
        }

        private void btnDelete1_Click(object sender, RoutedEventArgs e)
        {
            var selItem = dgProducts1.SelectedItem as products;
            KafeDBEntities1.GetContext().products.Remove(selItem);
            KafeDBEntities1.GetContext().SaveChanges();
            Manger.dgProducts.ItemsSource = KafeDBEntities1.GetContext().products.ToList();
        }

        private void dgProducts1_SelectionChanged()
        {

        }

        private void btnBack1_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            NewProduct window7 = new NewProduct(dgProducts1.SelectedItem as products);
            window7.Show();

        }
    }
}
