using System;

namespace PruebaSortArray
{
    public class Array
    {
        public static void Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 1; i < array.Length; j++)
                {
                    int AuxHash = 0;
                    int v1 = array[i - 1];
                    int v2 = array[i];
                    if (v1 >= v2)
                    {
                        AuxHash = v1;
                        v1 = v2;
                        v2 = array[j + 1];
                    }
                }
            }
        }
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
