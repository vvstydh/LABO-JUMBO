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
        string log;

        public MainPage()
        {
            InitializeComponent();
        }
        public MainPage(string _log)
        {
            InitializeComponent();

            if (_log != "")
            {
                User user = User.LoadUserByLogin(_log);
                userTextBlock.Text += user.NameAndSurname();

                log = _log;
            }
            else
            {
                userTextBlock.Text += "Неавторизованный";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Kinematica kinematica = new Kinematica(log);
            kinematica.Show();
            this.Close();
        }
    }
}
