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
            arrayPerros[0].Ladrar();
            arrayPerros[1].Ladrar();
            arrayPerros[2].Ladrar();
            arrayPerros[3].Ladrar();
        }
        public class Perro
        {
            protected string name; 
            public Perro(string name)
            {
                this.name = name;
            }
            public Perro()
            {
                this.name = "Max";
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