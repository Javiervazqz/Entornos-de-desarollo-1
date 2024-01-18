namespace SegundineGrado
{
    public class Program
    {
        static void Main(string[] args)
        {
            double a = 0.5, b = 2.5, c = 0.2;
            Console.WriteLine(EcuacionSegundoGrado.EcuacionDoble(ref a, ref b, ref c));
            Console.WriteLine(EcuacionSegundoGrado.EcuacionDobleOut(a, b, c, out double res1, out double res2));
        }
    }
}