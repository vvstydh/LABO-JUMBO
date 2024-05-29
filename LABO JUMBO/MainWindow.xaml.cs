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

namespace LABO_JUMBO
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (registr.IsChecked == true)
            {
                MainPage main = new MainPage("");
                main.Show();
                this.Close();
            }
            else
            {
                List<User> users = new List<User>();
                users = User.LoadAllUsers();

                if (login.Text != "" && password.Password != "")
                {
                    if (users.Where(x => x.login == login.Text).FirstOrDefault() != null)
                    {
                        User user = users.Where(x => x.login == login.Text).FirstOrDefault();
                        if (user.IsPasswordCorrect(password.Password))
                        {
                            MainPage main = new MainPage(user.login);
                            main.Show();
                            this.Close();
                        }
                        else { MessageBox.Show("Пароль не верный", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error); }
                    }
                    else { MessageBox.Show("Такого логина не существует", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error); }
                }
                else { MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error); }
            }
        }
        private void Register(object sender, RoutedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Close();
        }
    }
}
