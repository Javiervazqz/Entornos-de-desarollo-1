namespace CalculadoraLong
{
    public class Program
    {
        static void Main(string[] args)
        {
            long a = 12;
            long b = 14;
            List<int> list = utils.ConvertToList(a);
            List<int> list2 = utils.ConvertToList(b);
            List<int> list3 = Operations.Suma(list, list2);
            for (int i = 0; i < list3.Count; i++)
            {
                Console.Write(list3[i]);
            }
        }
    }
}