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
    /// Логика взаимодействия для WindowPay.xaml
    /// </summary>
    public partial class WindowPay : Window
    {
        public WindowPay()
        {
            InitializeComponent();
            lvOrder2.ItemsSource = Manger.lvOrder1.Items;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Заказ принят");
            Window1 window1 = new Window1();
            window1.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            tbSum1.Text = tbSum1.Text + 1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            tbSum1.Text = tbSum1.Text + 2;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            tbSum1.Text = tbSum1.Text + 3;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            tbSum1.Text = tbSum1.Text + 4;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            tbSum1.Text = tbSum1.Text + 5;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            tbSum1.Text = tbSum1.Text + 6;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            tbSum1.Text = tbSum1.Text + 7;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            tbSum1.Text = tbSum1.Text + 8;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            tbSum1.Text = tbSum1.Text + 9;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            tbSum1.Text = tbSum1.Text + 0;
        }

        private void btndelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btndelete_Click_1(object sender, RoutedEventArgs e)
        {
            int lenght = tbSum1.Text.Length - 1;
            string text = tbSum1.Text;
            tbSum1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                tbSum1.Text = tbSum1.Text + text[i];
            }
        }
    }
}
