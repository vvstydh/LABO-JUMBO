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
    /// Логика взаимодействия для CalcLaba1.xaml
    /// </summary>
    public partial class CalcLaba1 : Window
    {
        public CalcLaba1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int ugol = int.Parse(Ugol.Text);
            int dlina = int.Parse(Dlina.Text);
            int uglkef = int.Parse(Uglkef.Text);
            Uglusk.Text = (2 * uglkef).ToString();
        }
    }
}
