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
using static WpfApp1.MainWindow;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person _person = new Person()
        {
            Nombre = "Juan"
        };

        public MainWindow()
        {
            InitializeComponent();

            MyGrid.DataContext = _person;
        }

        private void AbrirSegundaVentana(object sender, RoutedEventArgs e)
        {
            Window2 window = new Window2();
            window.Show();
        }

        private void AnyadirProducto(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resultado = MessageBox.Show("Estas seguro de que quieres meter un producto?", "Confirmar", MessageBoxButton.YesNo);

        }

        public class Person
        {
            public string Nombre { get; set; }
        }
    }
}
