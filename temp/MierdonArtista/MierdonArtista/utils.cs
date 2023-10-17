using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MierdonArtista
{
    internal class utils
    {
        private static Random r = new Random();
        public static double GetRandom()
        {
            return r.NextDouble();
        }
    }
}
