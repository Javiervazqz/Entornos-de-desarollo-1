namespace MuerteYDestruccion
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = utils.ConvertToList(16);
            List<int> list2 = utils.ConvertToList(16);
            List<int> list3 = Operations.Suma(list, list2);
            for (int i = 0; i < list3.Count; i++)
            {
                Console.Write(list3[i]);
            }
        }
    }
}