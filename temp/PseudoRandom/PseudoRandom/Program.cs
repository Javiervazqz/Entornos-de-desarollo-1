namespace PseudoRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PseudoRandom.Get0to999());
        }
    }
    public static class PseudoRandom
    {
        public static int Get0to999()
        {
            return DateTime.Now.Millisecond;
        }
        //public static override string ToString()
        //{
        //    return $"El numero es: {Get0to999()}";
        //}
    }
}