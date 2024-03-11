using System.Security.Cryptography.X509Certificates;

namespace Parte4EX2JavierVazquezGarcia
{
    public class Program
    {
        // Javi: NOTA 0
        static void Main(string[] args)
        {
            ExList<string> list = new ExList<string>();
            list.Add("Juanito");
            list.Add("Navarrete");
            list.Add("Roberto");
            Console.WriteLine(list.Reverse());

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list.lista[i]);
            }
        }
    }
}