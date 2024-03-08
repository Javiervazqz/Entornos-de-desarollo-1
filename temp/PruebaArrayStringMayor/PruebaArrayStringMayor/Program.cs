namespace PruebaArrayStringMayor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "hola", "adios", "vengahastaluego", "yeybuenosdiasjhajkhasdf" };
            Empanao Roberto = new Empanao();
            Console.WriteLine(Roberto.GetGreater(strings));
        }
        public class Empanao
        {
            public string GetGreater(string[] strings)
            {
                int Count = strings.Length;
                string mayor;
                int lenM = 0;
                for (int i = 0; i < Count; i++)
                {
                    int len = 0;
                    string may;
                    foreach(char n in strings[i])
                    {
                        len++;
                    }
                    if (lenM > len)
                    {
                        may = strings[i];
                    }
                    lenM = len;
                    mayor = may;
                }
                return mayor;
            }
        }
    }
}