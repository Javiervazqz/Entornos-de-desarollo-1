using System;

namespace Prueba_foreach
{
    public class Foreaches
    {
        public static string? GetFrase()
        {
            Console.Write("Escribe tu frase: ");
            return Convert.ToString(Console.ReadLine());
        }
        public static char? GetLetra()
        {
            Console.Write("Ahora dime la letra que quieres que cuente en tu frase: ");
            return Convert.ToChar(Console.ReadLine());
        }
        public static void ContadorLetra()
        {
            string? frase = GetFrase();
            char? letra = GetLetra();
            int contador = 0;
            foreach (char c in frase)
            {
                if (c == letra)
                {
                    contador++;
                }
            }
            string res = ("La letra: " + letra + " ha salido un total de " + contador + " veces.");
            Console.Write(res);
        }
        public static void FuncionamientoPrueba()
        {
            string? frase = GetFrase();
            foreach (char c in frase)
            {
                Console.WriteLine(c);
            }
        }

    }
}
