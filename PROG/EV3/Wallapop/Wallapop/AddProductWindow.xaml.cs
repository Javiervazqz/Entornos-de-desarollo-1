using System.Windows;

namespace CompraVentaProductos
{
    public partial class AddProductWindow : Window
    {
        public AddProductWindow()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            // Aquí puedes implementar la lógica para guardar el nuevo producto
            Close();
        }
    }
}

