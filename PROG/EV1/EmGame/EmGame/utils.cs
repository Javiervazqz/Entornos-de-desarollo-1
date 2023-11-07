using System;

namespace EmGame
{
    public class utils
    {
        public static Random r = new Random();
        public static int GetRandom(int min, int max)
        {
            return r.Next(min, max);
        }
        public static int GreaterThanFour(int n1, int n2, int n3, int n4)
        {
            if (n1 > n2 && n1 > n3 && n1 > n4)
                return n1;
            if (n2 > n3 && n2 > n4)
                return n2;
            if (n3 > n4)
                return n3;
            else
                return n4;
        }
    }
}
