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
using Tarea5WPF.UI;

namespace Tarea5WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio4Capitulo10 ejercicio4Capitulo10 = new Ejercicio4Capitulo10();
            ejercicio4Capitulo10.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Ejercicio1Capitulo12 ejercicio1Capitulo12 = new Ejercicio1Capitulo12();
            ejercicio1Capitulo12.Show();
        }
    }
}
