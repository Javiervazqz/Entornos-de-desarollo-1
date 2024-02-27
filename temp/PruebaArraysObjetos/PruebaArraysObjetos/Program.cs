namespace PruebaArraysObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro[] arrayPerros = new Perro[3];
            arrayPerros[0] = new Perro("juan");
            arrayPerros[1] = new Dalmata("juanito");
            arrayPerros[2] = new Perro("juan");
            arrayPerros[0].Ladrar();
            arrayPerros[1].Ladrar();
            arrayPerros[2].Ladrar();
        }
        public class Perro
        {
            protected string name; 
            public Perro(string name)
            {
                this.name = name;
            }
            public virtual void Ladrar()
            {
                
                Console.WriteLine($"Guau, soy {name}");
            }
        }
        public class Dalmata : Perro
        {
            public Dalmata(string name) : base(name)
            {

            }
            public override void Ladrar()
            {
                base.Ladrar();
                Console.WriteLine($"Auuu, soy {name}");
            }
        }
    }
}