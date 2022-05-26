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
    /// Логика взаимодействия для PageHotDrinks.xaml
    /// </summary>
    public partial class PageHotDrinks : Page
    {
        public PageHotDrinks()
        {
            InitializeComponent();
        }

        private void btnHot_Copy5_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Американо");
        }

        private void btnHot_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Чай (ч)     59р");
        }

        private void btnHot_Copy_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Чай (з)     59р");
        }

        private void btnHot_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Латте     59р");
        }

        private void btnHot_Copy2_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Экспрессо     59р");
        }

        private void btnHot_Copy3_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Каппучино     59р");
        }

        private void btnHot_Copy4_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Глинтвейн     59р");
        }

        private void btnHot_Copy6_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Мокка     59р");
        }
    }
}
