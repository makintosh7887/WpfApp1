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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        public Window1()
        {
            InitializeComponent();
            Manger.MainFrame = MainFrame;
            Manger.lvOrder1 = lvOrder1;
            MainFrame.Content = new MenuPage();
            lFull1.Content = Manger.LabelFull;

            
        }

    

      

      

        private void miWarmHouse_Click(object sender, RoutedEventArgs e)
        {
            WindowProducts window4 = new WindowProducts();
            window4.Show();
            this.Hide();
        }

        private void miUsers_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
            this.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manger.lvOrder1 = lvOrder1;
            WindowPay window7 = new WindowPay();
            window7.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win2 = new MainWindow();
            win2.Show();
            this.Hide();
        }
    }
}
