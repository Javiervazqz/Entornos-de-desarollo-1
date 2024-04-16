namespace EntornosRarisimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = 2;
            int s = 0;
            int n;

            n = Int32.Parse(Console.ReadLine());
            while (j <= n / 2) //Bucle infinito porque hay numeros que no cumplen la condicion del while y del if
            {
                if (n % j == 0)
                {
                    s = s + 1;
                    break;
                }
                j = j + 1;
            }
            if (s == 0 && n > 1)
                Console.Write(n + " es primo");
            else
                Console.Write(n + " no es primo");
        }
    }
}