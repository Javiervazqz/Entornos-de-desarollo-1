using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entornos1
{
    internal class Class1
    {
        public static int SumarioRec(int n)
        {
            if (n <= 0)
                return 0;
            return n + SumarioRec(n - 1);
        }
    }
}
