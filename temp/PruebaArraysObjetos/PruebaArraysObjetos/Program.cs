using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace PruebaArraysObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro[] arrayPerros = new Perro[4];
            arrayPerros[0] = new Perro("Juan");
            arrayPerros[1] = new Dalmata("Juanito");
            arrayPerros[2] = new Perro("Juan");
            arrayPerros[3] = new Perro();
            Console.WriteLine(arrayPerros[0]);
            arrayPerros[1].Name = "Javiercin";
            Console.WriteLine(arrayPerros[1]);
            Console.WriteLine(arrayPerros[2]);
            Console.WriteLine(arrayPerros[3]);
        }
        public class Perro
        {
            public string Name { get; set; } 
            public Perro(string name)
            {
                Name = name;
            }
            public Perro()
            {
                Name = "Max";
            }
            public override string ToString()
            {
                return $"Guau, soy {Name}";
            }
        }
        public class Dalmata : Perro
        {
            public Dalmata(string name) : base(name)
            {

            }
            public override string ToString()
            {
                return base.ToString() + " y soy un dalmata";
            }
        }
    }
}