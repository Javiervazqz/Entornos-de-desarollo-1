namespace PruebaDisposCritika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Prueba p = CrearPrueba())
            {
                // if (bicho != null)
                // bicho.Dispose();
                //p.SayHello();
            }
            //p.Dispose();
        }
        public class Prueba : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("Dispose");
            }

            public void SayHello()
            {
                Console.WriteLine("Hello");
            }
        }
        public static Prueba CrearPrueba()
        {
            return null;//new Prueba();
        }
    }
}