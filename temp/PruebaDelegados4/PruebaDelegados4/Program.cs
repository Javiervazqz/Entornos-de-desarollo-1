using System.Security.Cryptography.X509Certificates;

namespace PruebaDelegados4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operaciones operacion = new Operaciones(numeracio => numeracio * numeracio);
            Console.WriteLine(operacion(4));

            Filter filtro = new Filter(num => num > 5);
            Console.WriteLine(filtro(7));

            Sumatron suma = new Sumatron((int v1, int v2) =>
            {
                v1 = 5;
                return v1 + v2;
            });
            Console.WriteLine(suma(1, 4));
    



            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> numerosPares = numeros.FindAll(i => i % 2 == 0);

            numerosPares.ForEach(numero => Console.WriteLine(numero));
            //Exactamente iguales
            foreach(int numero in numerosPares)
            {
                Console.WriteLine(numero);
            }
        }
    }
        public delegate int Operaciones(int numero);
        public delegate bool Filter(int num);
        public delegate int Sumatron(int v1, int v2);  
}