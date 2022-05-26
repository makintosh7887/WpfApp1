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
    /// Логика взаимодействия для PageDesserts.xaml
    /// </summary>
    public partial class PageDesserts : Page
    {
        public PageDesserts()
        {
            InitializeComponent();
        }

        private void btnHot_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Вафли     59р");
        }

        private void btnHot_Copy_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Чизкейк     119р");
        }

        private void btnHot_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Донат     99р");
        }

        private void btnHot_Copy2_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Тарталетка     99р");
        }

        private void btnHot_Copy3_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Пироженное     99р");
        }

        private void btnHot_Copy4_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Пицца     149р");
        }

        private void btnHot_Copy5_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Печенье     59р");
        }

        private void btnHot_Copy6_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Сладкий хлеб     59р");
           
        }
    }
}
