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
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnHot_Click(object sender, RoutedEventArgs e)
        {
            Manger.MainFrame.Content = new PageHot();
        }

        private void btnSalads_Click(object sender, RoutedEventArgs e)
        {
            Manger.MainFrame.Content = new PageSalads();
        }

        private void btnDrinks_Click(object sender, RoutedEventArgs e)
        {
            Manger.MainFrame.Content = new PageDrinks();
        }

        private void btnHotDrinks_Click(object sender, RoutedEventArgs e)
        {
            Manger.MainFrame.Content = new PageHotDrinks();
        }

        private void btnDesserts_Click(object sender, RoutedEventArgs e)
        {
            Manger.MainFrame.Content = new PageDesserts();
        }

        private void btnSauces_Click(object sender, RoutedEventArgs e)
        {
            Manger.MainFrame.Content = new PageSauces();
        }

    

        private void btnAlcohol_Click(object sender, RoutedEventArgs e)
        {
            Manger.MainFrame.Content = new PageAlcohol();
        }

        private void btnOther_Click(object sender, RoutedEventArgs e)
        {
            Manger.MainFrame.Content = new PageOther();
        }
    }
}
