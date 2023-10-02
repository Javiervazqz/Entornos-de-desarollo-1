using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace func
{
    internal class Functions
    {
        public static int GetMayor(int n1, int n2)
        {
            if (n1 > n2)
                return n1;
            return n2;
        }
        public static int Summation(int n1)
        {
            int i = 1;
            int j = 0;
            while (i <= n1)
            {
                j += i;
                i++;
            }
            return j;
        }
        public static int Summation2(int n1)
        {
            int j = 0;
            for (int i = 1; i <= n1; i++)
            {
                j += i;
            }
            return j;
        }

        public static bool OddEven(int n0)
        {
            if (n0 % 2 == 0)
                return true;
            return false;
        }
        public static int ParesRaros(int n1)
        {
            for (int n2 = 0; n2 < n1; n2 += 2)
                if (OddEven(n2 / 2))
                    Console.WriteLine(-n2);
                else
                    Console.WriteLine(n2);
            return n1;
        }
        public static bool Prime(int n1)
        {
            for (int i = 2; i < n1; i++)
                if ((n1 % i) == 0)
                    return false;
            return true;
        }
        public static int SeriesLuis(int n1)
        {
            int num = 0;
            for (int i = 1; num <= n1; i++)
            {
                if (OddEven(i))
                {
                    num -= 2;
                    i = -i;
                }
                else
                {
                    num += 5;
                    i = -i;
                }
                if (num >= n1)
                    return n1;
                Console.WriteLine(num);
            }
            return n1;
        }
        public static int MenorTres(int n1, int n2, int n3)
        {
            if ((n1 <= n2) && (n1 <= n3))
                return n1;
            if ((n3 <= n1) && (n3 <= n2))
                return n3;
            return n2;
        }
        public static int MenorTresDos(int n1, int n2, int n3)
        {
            if (n1 <= n2)
                if (n2 <= n3)
                    return n1;
                return n2;
            return n3;
        }
        public static int Productory(int n1)
        {
            int j = 1;
            for(int i = 1; i <= n1; i++)
            {
                j *= i;
            }
            return j;
        }
        public static int Paresrarisimos(int n1)
        {
            for (int i = 0; i <= n1; i+=2)
            {
                if (OddEven(i / 2))
                    Console.WriteLine(i);
                else
                    Console.WriteLine(-i);
            }
            return n1;
        }
        public static int superluis(int n1)
        {
            int j = 0;
            for (int i = 0; i <= n1; i++)
            {
                if (OddEven(i))
                {
                    j += 5;
                }
                else
                {
                    j -= 2;
                }
                if (j >= n1)
                    return n1;
                Console.WriteLine(j);
            }
            return n1;
        }
        public static int Examen(int n1)
        {
            int j = 0;
            if (n1 <= 5)
            {
                for (int i = 0; i <= n1; i++)
                {
                    j += i;
                }
                return j;
            }
            else
            {
                j = 1;
                for (int i = 1; i<=n1 ; i++)
                {
                    j *= i;
                }
                return j;
                if (j >= n1)
                    return n1;
                return n1;
            }
        }
        public static string Conca(string n1, string n2)
        {
            return n1 + "," + n2;
        }
        public static string SerieConca(int n1)
        {
            string n2 = "";
            for(int i = 0; i <= n1; i++)
            {
                n2 += "," + i;
            }
            return n2;
        }
        public static string Serie1str(int n1)
        {
            string n2 = "";
            int n3 = 1;
            for(int i = 0; i <= n1; i++) // se pueden poner mas de una instrucción separada por una coma
            {
                if (i == n1 - 1)
                {
                    n2 += n3;
                    return n2;
                }
                if (i >= n1)
                    return n2;
                n2 += n3 + ",";
                n3 *= 2;
            }
            return n2;
        }
            public static string ConcaSerie(int n1)
        {
            string n2 = "";
            string n3 = "";
            for (int i = 0; i <= n1; i++)
            {
                if (i >= n1)
                    return n2;
                n3 = n2 + Conca(n2 + i , n3 + i);
            }
            return n3;
        }
        public static int Repeticion(int n1, int n2)
        {
            for (int i = 1; i < n2; i++)
            {
                Console.WriteLine(n1);
            }
            return n1;
        }
        public static int unoalcien(int n1)
        {
            for(int i = 1; i<= n1; i++)
            {
                if ((i % 2 == 0) || (i % 3 == 0))
                    Console.WriteLine(i);
            }
            return n1;
        }
        public static string Fibonacci(int n1)
        {
            string cad = "0";
            int num1 = 0;
            int num2 = 1;
            int num3 = 1;
            for (int i = 0; i <= n1 - 2; i++)
            {
                num1 = num2;
                num2 = num3;
                num3 = num1 + num2;
                cad = cad + "," + num2;
            }
            return cad;
        }
        public static string Fibonacci2(int n1)
        {
            string cad = "0";
            int n0 = 0, n2 = 1, n3 = 1;
            while (n3 != n1)
            {
                if (n3 >= n1)
                    return cad + "," + n1;
                else
                {
                    n0 = n2; n2 = n3; n3 = n0 + n2;
                    cad = cad + "," + n2;
                }
            }
            return cad + "," + n1;
        }
        public static int RecSum(int n1)
        {
            for (int i = 0; i < n1; i++)
            {
                Console.WriteLine(RecSum(n1-i));
            }
            return n1;
        }
    }
}