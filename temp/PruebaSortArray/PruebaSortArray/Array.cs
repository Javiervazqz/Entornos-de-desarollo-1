using Microsoft.Office.Interop.Outlook;
using System;

namespace PruebaSortArray
{
    public class Array
    {
        int[] _array = new int[5];
        _array[0] = 2;
        _array[1] = 5;
        _items[2] = 0;
        public void Sort()
        {
            for (int i = 1, j = 0; i < _items.Length; i++, j++)
            {
                int AuxHash = 0;
                int v1 = _items[i - 1];
                int v2 = _items[i];
                if (v1 >= v2)
                {
                    AuxHash = v1;
                    v1 = v2;
                    v2 = _items[i + 1];
                }
            }
        }
    }
}
