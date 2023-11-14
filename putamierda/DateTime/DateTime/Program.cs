namespace DateTime
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(24, 09, 2005);
            Console.WriteLine(date.DayOfWeek());
        }
    }
}