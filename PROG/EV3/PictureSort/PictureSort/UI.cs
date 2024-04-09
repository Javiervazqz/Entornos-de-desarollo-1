namespace PictureSort
{
    public class UI
    {
        public string[]? GetPaths()
        {
            Console.Write("Dime el número de rutas que me vas a pasar: ");
            var count = Console.ReadLine();
            bool IsValid = true;
            int Count = 0;
            if (Int32.Parse(count) <= 0)
                IsValid = false;
            if (IsValid)
                Count = Int32.Parse(count);
            string[] rutas = new string[Count];
            for (int i = 1; i <= Count; i++)
            {
                Console.Write("Dime la ruta " + i + " :");
                var r = Console.ReadLine();
                try
                {
                    if (Int32.Parse(r) <= 0 || Int32.Parse(r) > 0)
                    {
                        throw new Exception("Eso no es una ruta");
                    }
                }
                catch (Exception)
                {
                    rutas[i] = r;
                }
            }
            return rutas;
        }
    }
}
