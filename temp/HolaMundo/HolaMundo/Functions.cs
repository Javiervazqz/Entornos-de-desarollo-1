using System.Reflection.Metadata.Ecma335;

namespace functions
{
    internal class Functions
    {
        public static int GetMayor(int n1, int n2)
        {
            if (n1 > n2)
                return n1;
            return n2;
        }
        public static int Sumation(int n1)
        {
            int i = 1;
            int j = 0;
            while (i <= n1)
            {
                j = j + i;
                i++;
            }
            return j;
        }
    }
}
