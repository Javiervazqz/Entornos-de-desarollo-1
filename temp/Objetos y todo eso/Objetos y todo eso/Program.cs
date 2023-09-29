namespace Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dolphin d1;
            Dolphin d2;
            d1 = new Dolphin(100.0,800.0);
            d1.size = 10.0;
            d1.SetHp(100.0);
            double l;
            l = d1.GetHp();
            d1.name = "Jose Luis";
            d1.color = ColorType.blue;
            d2 = new Dolphin();
            d2.size = 20.0;
            d2.SetHp(1000.0);
            double m;
            m = d2.GetHp();
            d2.name = "Paco";
            d2.color = ColorType.red;
        }
    }
}
