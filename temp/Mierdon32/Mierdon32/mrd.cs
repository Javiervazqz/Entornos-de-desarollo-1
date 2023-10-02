using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mierdon32
{
    internal class mrd
    {
        public static int FuncLista1(List<int> list)
        {
            return list.Count;
        }
        public static int FuncLista2(List<double> list)
        {
            int j = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > 0.0)
                    j++;
            }
            return j;
        }
    }
}
