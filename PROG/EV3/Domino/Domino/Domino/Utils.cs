namespace Domino
{
    public class Utils
    {
        public static double GetRandomInt(int n1)
        {
            Random rnd = new Random();
            return rnd.Next(n1);
        }
    }
}
