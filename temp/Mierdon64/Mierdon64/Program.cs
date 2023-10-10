using System.Buffers;

namespace Mierdon64
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] st = new string[4];
            st[0] = "hola";
            st[1] = "buenos";
            st[2] = "días";
            st[3] = "adiós";
            bool r1 = BibliotecaDeMierda.Operations.Contains(st, "hola");
            Console.Write(r1);
        }
    }
}