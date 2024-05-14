using ApplicationModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Wallapop
{
    public partial class MainWindow : Window
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public MainWindow()
        {
            InitializeComponent();

            Products.Add(new Product { Name = "Artículo 1", Description = "Descripción del artículo 1" });
            Products.Add(new Product { Name = "Artículo 2", Description = "Descripción del artículo 2" });


            DataContext = this;

        }
        //private List<Product> LoadProducts()
        //{
            // Aquí cargarías los productos desde tu fuente de datos
            // Por ejemplo, desde una base de datos o un archivo
            // Devuelve una lista de productos con las rutas de imagen
        //}
        private BitmapImage LoadImage(string imagePath)
        {
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(imagePath, UriKind.RelativeOrAbsolute);
            image.EndInit();
            return image;
        }
    }
}
