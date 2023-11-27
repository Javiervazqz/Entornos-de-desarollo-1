using System;

namespace PracticaExamenRancio
{
    public class utils
    {
        Random random = new Random();

        public static double GetRandomDouble()
        {
            Random random = new Random();
            return random.NextDouble();
        }
        public static int GetRandomInt(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
