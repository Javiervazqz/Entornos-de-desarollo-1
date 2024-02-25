using System;

namespace PruebaDelegados
{
    public class Prueba
    {
        public delegate int calculador(int v1, int v2);
        public class repaso
        {
            public static int Calculadora(int v1, int v2, calculador c)
            {
                return c(v1, v2);
            }
            public static void IniciarCalculadora()
            {
                Console.Write("Dame el primer valor:");
                int v1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Dame el segundo valor:");
                int v2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Elige una opcion, 1 suma, 2 resta, 3 div, 4 multi:");
                int optype = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                double result;
                switch (optype)
                {
                    case 1:
                        result = Calculadora(v1, v2, (v1, v2) => v1 + v2);
                        Console.Write(result);
                        break;
                    case 2:
                        result = Calculadora(v1, v2, (v1, v2) => v1 - v2);
                        Console.Write(result);
                        break;
                    case 3:
                        result = Calculadora(v1, v2, (v1, v2) => v1 / v2);
                        Console.Write(result);
                        break;
                    case 4:
                        result = Calculadora(v1, v2, (v1, v2) => v1 * v2);
                        Console.Write(result);
                        break;
                }
            }
        }
    }
}
