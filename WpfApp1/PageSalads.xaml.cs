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
    /// Логика взаимодействия для PageSalads.xaml
    /// </summary>
    public partial class PageSalads : Page
    {
        public PageSalads()
        {
            InitializeComponent();
            
        }

        private void btnHot_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Цезарь     350р");
        }

        private void btnHot_Copy2_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Крабовый     140р");
        }

        private void btnHot_Copy_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Русский     140р");
        }

        private void btnHot_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Английский     140р");
        }

        private void btnHot_Copy3_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Нежность     130р");
        }

        private void btnHot_Copy4_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Чим-Чим     130р");
        }

        private void btnHot_Copy5_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Любовник     130р");
        }

        private void btnHot_Copy6_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1.Items.Add("Обжорка     130р");
        }
    }
}
