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
    }
}
