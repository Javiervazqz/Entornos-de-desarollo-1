namespace Pruebaficheros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe el nombre del fichero: ");
            string name = Console.ReadLine();
            string[] lineas = File.ReadAllLines(name);
            for (int i = 0; i < lineas.Length; i++)
            {
                lineas[i] = lineas[i].ToUpper();
                Console.WriteLine(lineas[i]);
            }
        }
    }
}