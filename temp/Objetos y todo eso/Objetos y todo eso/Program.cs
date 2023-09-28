using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dolphin d1;
            Dolphin d2;
            d1 = new Dolphin();
            d1.size = 10.0;
            d1.life = 100.0;
            d1.name = "Jose Luis";
            d1.color = ColorType.blue;
            d2 = new Dolphin();
            d2.size = 20.0;
            d2.life = 1000.0;
            d2.name = "Paco";
            d2.color = ColorType.red;
        }
    }
}
