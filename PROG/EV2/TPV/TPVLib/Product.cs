using Microsoft.VisualBasic;

namespace TPVLib
{
    public class Product
    {
        public enum Availability
        {
            AVAILABLE,
            NOTAVAILABLE
        }
        public string name { get; set; }
        public string description { get; set; }
        public double precio { get; set; }
        public int stock { get; set; }
        public long id { get; set; }
        public double IVA { get; set; }
        public Availability availability { get; set; }
        //public var image { get; set; }
        public Product Clone(Product copy)
        {
            copy.name = name;
            copy.description = description;
            copy.precio = precio;
            copy.stock = stock;
            copy.id = id;
            copy.IVA = IVA;
            copy.availability = availability;
            //copy.image = image;
            return copy;
        }
        public void Update(Product product)
        {
            name = product.name;
            description = product.description;
            precio = product.precio;
            stock = product.stock;
            id = product.id;
            IVA = product.IVA;
            availability = product.availability;
            //image = product.image;
        }
    }
}
