using ApplicationModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Wallapop
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> Products { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Products = new ObservableCollection<Product>
            {
                new Product { Name = "Shrek", Description = "Peluche Shrek verde como un moco", ImagePath = "C:\\Users\\javvazgar\\Documents\\GitHub\\Entornos-de-desarollo-1\\PROG\\EV3\\Wallapop\\imagesshrek.jpeg", Price = 9999.99 },
                new Product { Name = "Artículo 2", Description = "Descripción del artículo 2", ImagePath = "C:\\Users\\javvazgar\\Documents\\GitHub\\Entornos-de-desarollo-1\\PROG\\EV3\\Wallapop\\images\\image2.jpg", Price = 15.99 }
            };

            DataContext = this;
        }

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