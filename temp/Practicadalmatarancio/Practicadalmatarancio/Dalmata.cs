using System;

namespace Practicadalmatarancio
{
    public class Dalmata : Perro
    {
        public void Ladrar()
        {
            base.Ladrar();
            Console.WriteLine("marica");
        }
        public override void ToString()
        {
            Console.WriteLine("Soy un dalmata y me llamo " + _name);
        }
    }
}
