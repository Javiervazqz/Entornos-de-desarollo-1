using TPVLib;

namespace TPV
{
    public class Test
    {
        public static void Start()
        {
            ITPV tpv = ITPV.CreateNewTPV();
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("1 - Buscar producto");
                Console.WriteLine("2 - Introducir producto");
                var option = UI.ReadOption();
            }
        }
    }
}