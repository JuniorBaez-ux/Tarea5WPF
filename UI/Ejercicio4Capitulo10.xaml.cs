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
using Tarea5WPF.Entidades;

namespace Tarea5WPF.UI
{
    /// <summary>
    /// Interaction logic for Ejercicio4Capitulo10.xaml
    /// </summary>
    public partial class Ejercicio4Capitulo10 : Window
    {
        Poligonos poli = new Poligonos();
        public Ejercicio4Capitulo10()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            ResultadoTextBox.Text = Multiplicar(poli.Lados = Utilidades.ToInt(LadosTextBox.Text), poli.Longitud = Utilidades.ToInt(LongitudTextBox.Text)).ToString();
        }

        private int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;

            return resultado;
        }
    }
}
