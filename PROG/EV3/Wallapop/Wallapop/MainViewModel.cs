using ApplicationModel;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace CompraVentaProductos
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private Product productoSeleccionado;

        public MainViewModel()
        {
            Productos = new ObservableCollection<Product>();
        }

        public ObservableCollection<Product> Productos { get; set; }

        public Product ProductoSeleccionado
        {
            get { return productoSeleccionado; }
            set
            {
                productoSeleccionado = value;
                OnPropertyChanged(nameof(ProductoSeleccionado));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
