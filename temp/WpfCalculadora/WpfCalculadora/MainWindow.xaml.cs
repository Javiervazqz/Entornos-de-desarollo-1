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

namespace WpfCalculadora
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string num1 = TextBox1.Text;
            string num2 = TextBox2.Text;
            int n1 = int.Parse(num1);
            int n2 = int.Parse(num2);
            int n3 = n1 + n2;
            MessageBox.Show("El resultado es: " + n3);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string nuevaimg = "C:\\Users\\usuario\\Pictures\\giorno-pato.jpg";
            BitmapImage bitmap = new();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(nuevaimg);
            bitmap.EndInit();

            MyImage.Source = bitmap;
        }
    }
}
