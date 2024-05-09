using System;
using System.Collections.Generic;
using System.IO;
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

namespace LABO_JUMBO
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void registrationButton_Click(object sender, RoutedEventArgs e)
        {
            List<User> users = new List<User>();
            users = User.LoadAllUsers();

            if(loginTextBox.Text != "" && passwordTextBox.Password != ""
                && nameTextBox.Text != "" && surnameTextBox.Text != "")
            {
                if(users.Where(x => x.login == loginTextBox.Text).FirstOrDefault() == null)
                {
                    User user = new User(loginTextBox.Text, passwordTextBox.Password,
                nameTextBox.Text, surnameTextBox.Text);

                    using (StreamWriter sw = new StreamWriter("users.txt", true))
                    {
                        sw.WriteLine(user.ToString());
                    }
                }
                else { MessageBox.Show("Такой логин уже существует", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error); }
            }
            else { MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error); }
            
        }
    }
}
