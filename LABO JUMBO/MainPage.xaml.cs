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

namespace LABO_JUMBO
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Window
    {
        public MainPage(string log)
        {
            InitializeComponent();

            if (log != "")
            {
                User user = User.LoadUserByLogin(log);
                userTextBlock.Text += user.NameAndSurname();
            }
            else
            {
                userTextBlock.Text += "Неавторизованный";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Laba1Calc calc = new Laba1Calc();
            calc.Show();
        }
    }
}
