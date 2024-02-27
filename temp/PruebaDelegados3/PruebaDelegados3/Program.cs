namespace PruebaDelegados3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int valor = 5;
            delegateCheck check = new delegateCheck(delegate (int v) {
                return v >= 5; // For example, checking if the value is greater than 5
            });

            bool result = Filter(valor, check);
            Console.WriteLine(result);
        }

        public delegate bool delegateCheck(int v);

        public static bool Filter(int value, delegateCheck checker)
        {
            return checker(value);
        }
    }
}