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
    /// Логика взаимодействия для PageAlcohol.xaml
    /// </summary>
    public partial class PageAlcohol : Page
    {
        int sum;
        public PageAlcohol()
        {
            InitializeComponent();
            Manger.Sum = 0;

        }

        private void btnHot_Copy_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Балтика 9     149р");
           
        }

        private void btnHot_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Балтика 3     149р");


        }

        private void btnHot_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Мотор     149р");
        }

        private void btnHot_Copy2_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Garage     149р");
        }

        private void btnHot_Copy3_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Dr Disel     149р");
        }

        private void btnHot_Copy4_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Три озера     149р");
        }

        private void btnHot_Copy5_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Талка     149р");
        }

        private void btnHot_Copy6_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("365 дней     149р");
        }
    }
}
