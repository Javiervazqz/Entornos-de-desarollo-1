using System;

namespace MuerteYDestruccion
{
    public class utils
    {
        public static long GetLongLength(long num)
        {
            long length = 0;
            long n1 = num;
            for (int i = 0; n1 > 0; i++)
            {
                if (n1 > 0)
                    length++;
                n1 = n1 / 10;
            }
            return length;
        }
        public static List<int> ConvertToList(long n1)
        {
            List<int> l1 = new List<int>();
            long length = GetLongLength(n1);
            for (int i = 0; i < length; i++)
            {
                int coc = (int)n1 / 10;
                int resto = (int)n1 % 10;
                l1.Add(resto);
                n1 = coc;
            }
            return InvertList(l1);
        }
        public static List<int> InvertList(List<int> list)
        {
            List <int> l1 = new List<int>();
            for (int j = list.Count - 1; j >= 0; j--)
            {
                l1.Add(list[j]);
            }
            return l1;
        }
    }
}
