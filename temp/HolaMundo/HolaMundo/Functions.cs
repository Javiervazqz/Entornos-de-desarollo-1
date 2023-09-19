using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace funciones
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
            int i = 1;
            int j = 0;
            for (i = 1; i <= n1; i++)
            {
                j += i;
            }
            return j;
        }
        public static int Paresraros(int n1)
        {
            int j = n1 - 1;
            int i = -2;
            {
                if (i >= n1)
                    return n1;
                if (i > 0)
                    Console.WriteLine(i);
                    i += 2;
                    i = (-i);
                Console.WriteLine(i);
                i = -i;
                i += 2;
                
            }
            return i;
        }
            
    }
}
