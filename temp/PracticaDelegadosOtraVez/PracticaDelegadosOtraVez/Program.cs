namespace PracticaDelegadosOtraVez
{
    internal abstract class Program
    {
        static void Main(string[] args)
        {
            List<int> enteros = new() { 1,2,3,4,5,6,7,8,9,10 };
            //DelegadoEnteros delegadoint = (value) => Console.WriteLine(--value);
            //delegadoint(enteros[0]);
            //MiDelegado delegado = (value) => Console.WriteLine($"hola {value}");
            //delegado("javi");
            //Visitor filtro = (value) => value % 2 != 0;
            //foreach (int n in enteros)
            //{
            //    if (filtro(n))
            //        Console.WriteLine(n);
            //}
            //int valor1 = 5;
            //int valor2 = 3;
            //Calculador suma = (valor1, valor2) => valor1 + valor2;
            //Calculador resta = (valor1, valor2) => valor1 - valor2;
            //Calculador multiplicacion = (valor1, valor2) => valor1 * valor2;
            //Calculador division = (valor1, valor2) => valor1 / valor2;
            //Calcular(valor1, valor2, division);
            ProcesadorCadena mayus = (cadena) => cadena.ToUpper();
            ProcesadorCadena minus = (cadena) => cadena.ToLower();
            ProcesadorCadena 
        }
        public delegate void MiDelegado(string value);
        public delegate void DelegadoEnteros(int value);
        public delegate bool Visitor(int value);
        public delegate double Calculador(int value1, int value2);
        public delegate string ProcesadorCadena(string cadena);
        public static void Calcular(int v1, int v2, Calculador calculador)
        {
            Console.WriteLine(calculador(v1, v2));
        }
        public static void ImprimirString(string value)
        {
            Console.WriteLine(value);
        }
    }
}