namespace PruebaSortArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 2, 3, 5, 1, 8 };
            Array.Sort(array);
            Array.PrintArray(array);
        }
    }
}