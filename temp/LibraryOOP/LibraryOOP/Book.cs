using System;

namespace LibraryOOP
{
    public class Book : Product
    {
        int numPages;

        public Book(int codProd, string title, int numPages) : base(codProd, title)
        {
            this.numPages = numPages;
        }
        public override string ToString()
        {
            Console.WriteLine();
            Console.WriteLine("Libro: ");
            Console.WriteLine(base.ToString());
            return $"Numero paginas {numPages}";
        }
    }
}
