using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MierdonArtista
{
    public class Character
    {
        public Rectangle rect = new Rectangle();
        public double x;
        public double y;
        public double w;
        public double h;
        public double red = utils.GetRandom();
        public double green = utils.GetRandom();
        public double blue = utils.GetRandom();
        public double alpha;
    }
}
