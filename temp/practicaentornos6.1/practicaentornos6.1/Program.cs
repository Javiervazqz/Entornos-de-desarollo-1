namespace ConsoleApplication1
{
    class Program
    {
        static int funcion(int a, int b)
        {
            int resultado;
            if (a < b)
                resultado = a;
            else
                resultado = funcion(a - b, b);
            return resultado;
        }
        static void Main(string[] args)
        {
            funcion(5, 2);
        }
    }
}

