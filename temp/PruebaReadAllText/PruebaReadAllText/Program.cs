using System.IO;

namespace PruebaReadAllText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe el nombre del fichero de texto: ");
            string nombreFichero = Console.ReadLine();
            string contenidoFichero = File.ReadAllText(nombreFichero);
            while (contenidoFichero.Contains("  "))
            {
                contenidoFichero = contenidoFichero.Replace("  ", " ");
            }
            File.WriteAllText(nombreFichero + ".hola.txt", contenidoFichero);
        }
    }
}