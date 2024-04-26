namespace PictureSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UI ui = new UI();
            string[]? paths = ui.GetPaths();
        }
    }
}