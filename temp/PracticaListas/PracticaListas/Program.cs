namespace PracticaListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(3);
            list.Add(2);
            list.Add(2);
            list.Add(9);
            list.Add(5);
            list = SortList(list);
            for (int i = 0; i< list.Count; i++)
            {
                Console.Write(list[i] + " ,");
            }
        }
        public static List<int> SortList(List<int> l)
        {
            int aux;
            for (int i = 1; i <= l.Count - 1; i++)
            {
                for (int j = 1; j < l.Count - 1; j++)
                {
                    if (l[i - 1] >= l[i])
                    {
                        aux = l[i - 1];
                        l[i - 1] = l[i];
                        l[i] = aux;
                    }
                }
            }
            return l;
        }
    }
}