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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        users users = new users();
        public Window3(users selectedUser)
        {
            InitializeComponent();
            DataContext = users;
            if (selectedUser != null)
            {
                users = selectedUser;
            }
            DataContext = users;


        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (users.id == 0)
            {
                KafeDBEntities1.GetContext().users.Add(users);
            }
            try
            {
                KafeDBEntities1.GetContext().SaveChanges();
                MessageBox.Show("Успешно");
                Manger.dgUser.ItemsSource = KafeDBEntities1.GetContext().users.ToList();
                this.Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
