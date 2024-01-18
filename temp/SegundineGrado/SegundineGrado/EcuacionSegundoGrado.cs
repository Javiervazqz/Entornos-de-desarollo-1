using System;

namespace SegundineGrado
{
    public class EcuacionSegundoGrado
    {
        public static (double res1, double res2) EcuacionDoble(ref double a, ref double b, ref double c)
        {
            if (a == 0)
                return (double.NaN, double.NaN);
            double r = b * b - 4 * a * c;
            if (r < 0)
                return (double.NaN, double.NaN);
            double root = Math.Sqrt(r);
            double denom = 1.0 / (2.0 * a);
            double res1 = (-b + root) * denom;
            double res2 = (-b - root) * denom;
            return (res1, res2);
        }
        public static bool EcuacionDobleOut(double a, double b, double c, out double res1, out double res2)
        {
            res1 = double.NaN;
            res2 = double.NaN;
            if (a == 0.0)
                return false;
            double r = b * b - 4 * a * c;
            if (r < 0)
                return false;
            double root = Math.Sqrt(r);
            double denom = 1.0 / (2.0 * a);
            res1 = (-b + root) * denom;
            res2 = (-b - root) * denom;
            return true;
        }
        public static bool EcuacionDobleOut(double a, double b, double c, out double res1, out double res2)
        {
            double (r1,r2) = EcuacionDoble(ref a, ref b, ref c);
            if ()
        }
    }
}
