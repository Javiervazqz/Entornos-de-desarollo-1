namespace Practicadalmatarancio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro d = new Dalmata();
            d.Name = "Juan";
            d.Ladrar();
            d.ToString();
            string name = d.Name;
            Console.Write(name);
        }
    }
}