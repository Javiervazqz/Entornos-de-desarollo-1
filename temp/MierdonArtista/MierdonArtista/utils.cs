﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MierdonArtista
{
    internal class utils
    {
        public static Random r = new Random();
        public static double GetRandom()
        {
            return r.NextDouble();
        }
        public static double GetRandomized(double min, double max)
        {
            double res = GetRandom() * (max - min) - min;
            return res;
        }
    }
}
