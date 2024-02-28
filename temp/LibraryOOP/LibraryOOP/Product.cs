using System;

namespace LibraryOOP
{
    public class Product
    {
        protected int codProd;
        protected string? title;
        public Product(int codProd, string title)
        {
            this.codProd = codProd;
            this.title = title;
        }
        public override string ToString()
        {
            return $"Codigo: {codProd}, Titulo: {title}";
        }
    }
}
