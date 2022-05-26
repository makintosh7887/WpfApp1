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
    /// Логика взаимодействия для NewProduct.xaml
    /// </summary>
    public partial class NewProduct : Window
    { 
        products Products = new products();
        public NewProduct(products SelectProducts)
        {
            InitializeComponent();
            DataContext = Products;
            if (SelectProducts != null)
            {
                Products = SelectProducts;
            }
            DataContext = Products;
        }
       

        private void BtnNewProduct_Click(object sender, RoutedEventArgs e)
        {
            if (Products.id == 0)
            {
                KafeDBEntities1.GetContext().products.Add(Products);
            }
            try
            {
                KafeDBEntities1.GetContext().SaveChanges();
                MessageBox.Show("Успешно");
                Manger.dgProducts.ItemsSource = KafeDBEntities1.GetContext().products.ToList();
                this.Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
