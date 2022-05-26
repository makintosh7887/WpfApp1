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
    /// Логика взаимодействия для PageHot.xaml
    /// </summary>
    public partial class PageHot : Page
    {
        public PageHot()
        {
            InitializeComponent();
        }

        private void btnHot_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Плов     170р");

        }

        private void btnHot_Copy_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Колдуны     235р");
        }

        private void btnHot_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Котлета     150р");
        }

        private void btnHot_Copy2_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Рис     110р");
        }

        private void btnHot_Copy3_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Курица     199р");
        }

        private void btnHot_Copy4_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Мясо     235р");
        }
    }
}
