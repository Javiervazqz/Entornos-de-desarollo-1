using System;

namespace LibraryOOP
{
    public class Movie : Product
    {
        int releaseYear;
        string? director;
        public Movie(int codProd, string title, int releaseYear, string director) : base(codProd, title)
        {
            this.releaseYear = releaseYear;
            this.director = director;
        }
        public override string ToString()
        {
            Console.WriteLine();
            Console.WriteLine("Pelicula: ");
            Console.WriteLine(base.ToString());
            return $"Estreno: {releaseYear}, Director: {director}";
        }
    }
}
