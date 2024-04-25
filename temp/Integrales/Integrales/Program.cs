using System.Threading.Channels;

namespace Integrales
{
    internal class Program
    {
        public delegate double MathFunction(double x);
        public static double CalcularAreaIntegral(MathFunction mf, double x0, double x1, double dx)
        {
            double area = 0.0;
            for(double i = x0; i < x1; i += dx)
            {
                area += mf(i) * dx;
            }
            return area;
        }
        static void Main(string[] args)
        {
            double x0 = 0.0;
            double x1 = 5.0;
            double dx = 0.0001;
            var area = CalcularAreaIntegral(x =>
            {
                return 2 * (x * x * x) + x;
            }, x0, x1, dx);
            Console.WriteLine(area);
        }
    }
}