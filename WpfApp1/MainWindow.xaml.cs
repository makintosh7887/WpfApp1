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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        users validate = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            tbpar.Text = tbpar.Text + 2;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            tbpar.Text = tbpar.Text + 1;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            tbpar.Text = tbpar.Text + 3;
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            tbpar.Text = tbpar.Text + 4;
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            tbpar.Text = tbpar.Text + 5;
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            tbpar.Text = tbpar.Text + 6;
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            tbpar.Text = tbpar.Text + 7;
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            tbpar.Text = tbpar.Text + 8;
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            tbpar.Text = tbpar.Text + 9;
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            tbpar.Text = tbpar.Text + 0;
        }

        private void btndelete_Click(object sender, RoutedEventArgs e)
        {
            int lenght = tbpar.Text.Length - 1;
            string text = tbpar.Text;
            tbpar.Clear();
            for (int i = 0; i < lenght; i++)
            {
                tbpar.Text = tbpar.Text + text[i];
            }
        }

            //Листинг кода проверки PIN-кода
            public void ValidateUsers( string pass)
            {
            validate = KafeDBEntities1.GetContext().users.Where(p => p.Pass == pass).FirstOrDefault();
                if (validate != null)
                {
                    MessageBox.Show($"Добро пожаловать, {validate.Name} {validate.Patronymic}");
                    Window1 window1 = new Window1();
                    window1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неправильный PIN-код");
                }

            }

        private void btnnext_Click(object sender, RoutedEventArgs e)
        {
            string pass = tbpar.Text;
                ValidateUsers(pass);
            
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
