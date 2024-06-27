namespace PruebaArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] png = Directory.GetFiles(".", "*.png");
            string[] jpg = Directory.GetFiles(".", "*.jpg");

            List<string> lista = new List<string>();
            lista.AddRange(png);
            lista.AddRange(jpg);
            lista.Sort();

            foreach(string s in lista)
            {
                Console.WriteLine(s);
            }
        }
    }
}