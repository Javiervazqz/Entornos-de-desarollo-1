namespace MuerteYDestruccion
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = utils.ConvertToList(169);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}