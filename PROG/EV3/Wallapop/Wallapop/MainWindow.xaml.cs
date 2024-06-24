using ApplicationModel;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace CompraVentaProductos
{
    public partial class MainWindow : Window
    {
        private MainViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();
            viewModel = new MainViewModel();
            DataContext = viewModel;
        }

        private void BtnAñadirProducto_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ProductImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var producto = ((FrameworkElement)sender).DataContext as Product;
            if (producto != null)
            {
                var detailWindow = new ProductDetailWindow(producto);
                detailWindow.Show();
            }
        }

        private void ProductName_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var producto = ((FrameworkElement)sender).DataContext as Product;
            if (producto != null)
            {
                var detailWindow = new ProductDetailWindow(producto);
                detailWindow.Show();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddProductWindow newWindow = new AddProductWindow();
            newWindow.Show();
        }
    }
}
