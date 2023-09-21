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
            if (n1 == 2)
                return true;
            if (n1 % 2 == 1)
                return true;
            else
                return false;
        }
        public static bool SeriesLuis(int n1)
        {
            int n2 = 0;
            int k = 1;
            bool l = (k == 1) || (k == -1);
            while (l == true)
                if (k == 1)
                    Console.WriteLine(n2);
                    n2 = n2 + 5;
                    k = k * -1;
                else
                Console.WriteLine(n2);
                n2 = n2 - 2;
                k = k * -1;
            return Convert.ToBoolean(n2);

        }
    }
}