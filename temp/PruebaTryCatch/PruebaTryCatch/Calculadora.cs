using System;

namespace PruebaTryCatch
{
    public class Calculadora
    {
        public static (T, T) GetValues<T>()
        {
            Console.Write("Dime el primer valor: ");
            T v1 = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));

            Console.WriteLine();

            Console.Write("Dime el segundo valor: ");
            T v2 = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));

            return (v1, v2);
        }
        public static void Suma<T>()
        {
            try
            {
                var (v1, v2) = GetValues<T>();
                var value1 = Convert.ToInt32(v1);
                var value2 = Convert.ToInt32(v2);
                var res = value1 + value2;
                Console.WriteLine(res);
                return;
            }
            catch (Exception ex)
            {
                Console.Write("Dato no numerico");
                return;
            }
        }
    }
}