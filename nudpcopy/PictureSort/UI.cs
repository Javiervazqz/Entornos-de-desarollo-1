namespace PictureSort
{
    public class UI
    {
        public static void ShowTitle()
        {
            Console.WriteLine("=== Copiador de Archivos ===");
            Console.WriteLine();
        }

        public static void ShowProcessingMessage()
        {
            Console.WriteLine("Procesando archivos...");
            Console.WriteLine();
        }

        public static void ShowCompletionMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Proceso completado.");
        }
    }
}
