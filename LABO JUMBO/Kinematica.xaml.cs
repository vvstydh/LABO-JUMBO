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
    /// Логика взаимодействия для Kinematica.xaml
    /// </summary>
    public partial class Kinematica : Window
    {
        string log;

        public Kinematica()
        {
            InitializeComponent();
        }

        public Kinematica(string _log)
        {
            InitializeComponent();

            log = _log;
            if (log == "" || log == null)
            {
                saveButton.IsEnabled = false;
                laba1vyvod.IsEnabled = false;
                log = "";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Laba1Calc laba1Calc = new Laba1Calc();
            laba1Calc.Show();
        }
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage(log);
            mainPage.Show();
            this.Close();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if(laba1vyvod.Text != "")
            {
                using (StreamWriter sw = new StreamWriter(string.Format($"{log}_Kinematika.txt"), false))
                {
                    sw.WriteLine(laba1vyvod.Text);
                    MainPage main = new MainPage(log);
                    main.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Введите хоть что нибудь", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
