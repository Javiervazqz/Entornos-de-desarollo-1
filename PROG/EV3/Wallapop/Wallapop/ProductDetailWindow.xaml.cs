using ApplicationModel;
using System.Windows;

namespace CompraVentaProductos
{
    public partial class ProductDetailWindow : Window
    {
        public ProductDetailWindow(Product producto)
        {
            InitializeComponent();
            DataContext = new ProductDetailViewModel { Producto = producto };
        }
    }

    public class ProductDetailViewModel
    {
        public Product Producto { get; set; }
    }
}

