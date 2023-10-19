using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MierdonArtista
{
    internal class Character
    {
        public class Character0
        {
            public double x;
            public double y;
            public double velocity = 0.005;
            public double red = utils.GetRandom();
            public double green = utils.GetRandom();
            public double blue = utils.GetRandom();
            public double alpha;
        }
    }
}
