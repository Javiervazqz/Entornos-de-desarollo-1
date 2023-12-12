namespace Mierdon256
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Person p2 = new Person("Jose", Gender.MALE);
            Teacher t = new Teacher(1);
            Teacher t1 = new Teacher()
            {
                name = "juanito juan",
                gender = Gender.MALE
            };
            Graveyard g = new Graveyard();
        }
    }
}