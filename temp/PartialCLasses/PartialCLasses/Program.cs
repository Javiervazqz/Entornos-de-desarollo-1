namespace PartialCLasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.Edad = 3;
            p.Nombre = "juan";
            Console.WriteLine(p.Edad);
            Console.WriteLine(p.Nombre);
        }
    }
}