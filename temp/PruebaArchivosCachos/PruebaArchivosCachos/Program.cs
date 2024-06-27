using System.IO;

namespace PruebaArchivosCachos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] datosImg = File.ReadAllBytes("pitufo.webp");

            byte aux = datosImg[0];
            datosImg[0] = datosImg[1];
            datosImg[1] = aux;

            File.WriteAllBytes("pitufo2.webp", datosImg);
        }
        
    }
}