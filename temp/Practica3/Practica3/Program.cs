namespace Practica3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Operaciones operaciones = new Suma();
            operaciones.SetValor1(3);
            operaciones.SetValor2(2);
            operaciones.Operar();
            Console.WriteLine(operaciones.GetResultado());
        }
    }
}