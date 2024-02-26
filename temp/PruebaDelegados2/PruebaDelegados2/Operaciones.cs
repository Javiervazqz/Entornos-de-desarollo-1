using System;
using System.Runtime.Intrinsics;

namespace PruebaDelegados2
{
    public class Operaciones
    {
        public delegate int Operar(int v1, int v2);
        public static (int, int) GetValues()
        {
            Console.Write("Primer valor: ");
            int v1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Segundo valor: ");
            int v2 = Convert.ToInt32(Console.ReadLine());
            return (v1, v2);
        }
        public static void Sumar()
        {
            (int v1, int v2) = GetValues();
            int result = AsignarOperar((v1, v2) => v1 + v2);
            Console.WriteLine(result);
        }
        public static int AsignarOperar(Operar op)
        {
            (int v1, int v2) = GetValues();
            return op(v1, v2);
        }
    }
}
