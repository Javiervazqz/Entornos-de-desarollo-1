using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
        public static bool Prime(int n1)
        {
            for (int i = 2; i < n1; i++)
                if ((n1 % i) == 0)
                    return false;
            return true;
        }
        public static int PrimosHasta(int n1)
        {
            int j = 0;
            for (int i = 1; i <= n1; i++)
            {
                if (Prime(i))
                    j++;
            }
            return j;
        }
        public static bool SearchInt(List<int> l, int n1)
        {
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i] == n1)
                    return true;
            }
            return false;
        }
        /// <summary>
        ///funcionq ue devuelve el numero mayor de una lista de enteros
        /// </summary>
        /// <param name="l">lista de enteros</param>
        /// <returns>numero mas alto de la lista, si l es null devuelve 0</returns>
        public static int GreaterList(List<int> l)
        {
            if (l == null || l.Count == 0)
                return int.MinValue;
            int k = l[0];
            for (int i = 1; i < l.Count; i++)
            {
                if (l[i] > k)
                    k = l[i];
            }
            return k;
        }
        public static int GreaterPosition(List<int> l)
        {
            if (l == null || l.Count == 0)
                return int.MinValue;
            int k = l[0];
            int index = 0;
            for (int i = 1; i < l.Count; i++)
            {
                if (l[i] > k)
                {
                    k = l[i];
                    index = i;
                }
            }
            return index;
        }
        public static bool Ascendant(List<int> l)
        {
            if (l == null || l.Count == 0)
                return false;
            int k = l[0];
            for (int i = 1; i < l.Count; i++)
            {
                if (l[i] > k)
                    k = l[i];
                else
                    return false;
            }
            return true;
        }
        public static bool Contains0(int n1)
        {
            int min = 0;
            int max = a.Length - 1;
            int mid = 0;
            while (min <= max)
            {
                mid = (min + max) / 2;
                if (a[mid] == n1)
                    return true;
                if (n1 >= a[mid])
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }
            return false;
        }
        public static bool Contains(int n1)
        {
            int min = 0;
            int max = a.Length - 1;
            int mid = 0;
            while (min <= max)
            {
                mid = (min + max) / 2;
                if (a[mid] == n1)
                    return true;
                if (n1 >= a[mid])
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }
            return false;
        }
    }
}
