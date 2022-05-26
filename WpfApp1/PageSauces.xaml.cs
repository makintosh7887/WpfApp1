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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для PageSauces.xaml
    /// </summary>
    public partial class PageSauces : Page
    {
        public PageSauces()
        {
            InitializeComponent();
        }

        private void btnHot_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Майонез     30р");
        }

        private void btnHot_Copy_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Горчица     30р");
        }

        private void btnHot_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Сырный     30р");
        }

        private void btnHot_Copy2_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Кетчуп     30р");
        }

        private void btnHot_Copy3_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Сметана     30р");
        }

        private void btnHot_Copy4_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Грибной     30р");
        }

        private void btnHot_Copy5_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Аджика     30р");
        }

        private void btnHot_Copy6_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Соевый     30р");
        }
    }
}
