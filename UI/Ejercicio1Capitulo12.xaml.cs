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
    /// Interaction logic for Ejercicio1Capitulo12.xaml
    /// </summary>
    public partial class Ejercicio1Capitulo12 : Window
    {
        Factorial facto = new Factorial();
        public Ejercicio1Capitulo12()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            ResultadoTextBox.Text = CalculoFactorial(facto.Numero = Utilidades.ToInt(NumeroTextBox.Text.ToString())).ToString();
        }

        private int CalculoFactorial(int numero)
        {
            int j;
            for (j = numero; j >= 1; j--)
            {
                facto.FactorialN *= j;
            }

            return facto.FactorialN;
        }
    }
}
