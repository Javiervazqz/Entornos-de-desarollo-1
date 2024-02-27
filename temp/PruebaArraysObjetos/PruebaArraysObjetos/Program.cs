namespace PruebaArraysObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro[] arrayPerros = new Perro[3];
            arrayPerros[0] = new Perro();
            arrayPerros[1] = new Perro();
            arrayPerros[2] = new Perro();
            arrayPerros[0].Ladrar();
            arrayPerros[1].Ladrar();
            arrayPerros[2].Ladrar();
        }
        public class Perro
        {
            public void Ladrar()
            {
                Console.WriteLine("Guau");
            }
        }
    }
}