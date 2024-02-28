namespace LibraryOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            User us1 = new User("51111278R", "Javi", "Avenida Conrado Canals", "+34 613095123");

            Console.WriteLine("Usuario creado con nombre {0}\n", us1.fullName);

            Product[] products = new Product[4];
            products[0] = new Book(12345, "La tabla de Flandes", 320);
            products[1] = new Movie(31414, "Django desencadenado", 2003, "Quentin Tarantino");
            products[2] = new Book(649123, "El archivo de las tormentas", 967);
            products[3] = new Movie (74466, "Kung fu panda 3", 2019, "Juan Carlos I");

            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }
        }
    }
}