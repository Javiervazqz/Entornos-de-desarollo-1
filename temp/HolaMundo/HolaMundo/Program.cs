namespace HolaMundo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int r1;
            r1 = Functions.GetMayor(1, 2);
            Console.WriteLine(r1);
            int r2;
            r2 = Functions.GetMayor(10, -1);
            System.Console.WriteLine(r2);
        }
    }
}