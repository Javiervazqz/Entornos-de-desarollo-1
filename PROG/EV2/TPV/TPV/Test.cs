using TPVLib;

namespace TPV
{
    public class Test
    {
        static void Main(string[] args)
        {
            ITPV tpv = ITPV.CreateNewTPV();
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("1 - Buscar producto");
                Console.WriteLine("2 - Introducir producto");
                Console.WriteLine("3 - ");
                var option = UI.ReadOption();
            }
        }
    }
}