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
    /// Логика взаимодействия для Laba1Calc.xaml
    /// </summary>
    public partial class Laba1Calc : Window
    {
        public Laba1Calc()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double ugol = double.Parse(Ugol.Text) * Math.PI;
                double dlina = double.Parse(Dlina.Text);
                double uglkef = double.Parse(Uglkef.Text) * Math.PI;
                double uglusk = 2 * uglkef;
                Uglusk.Text = uglusk.ToString();
                double vrem = Math.Pow(2 * ugol / uglusk, 0.5);
                Vrem.Text = vrem.ToString();
                double uglscor = vrem * uglusk;
                Uglscor.Text = uglscor.ToString();
                double uskrt = uglusk * dlina;
                Uskrt.Text = uskrt.ToString();
                double uskrn = uglscor * uglscor * dlina;
                Uskrn.Text = uskrn.ToString();
                double uskro = Math.Pow(Math.Pow(uskrt, 2) + Math.Pow(uskrn, 2), 0.5);
                Uskro.Text = uskro.ToString();
                Error.Text = "";
            }
            catch (FormatException) { Error.Text = "Неверный формат введенных данных"; }
            catch (OverflowException) { Error.Text = "Введенные данные слишком большие или слишком малые"; }
        }
    }
}
