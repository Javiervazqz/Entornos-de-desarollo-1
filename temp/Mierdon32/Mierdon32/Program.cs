﻿using System.Collections;
namespace Mierdon32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();
            l.Add(1);
            l.Add(4);
            l.Add(5);
            l.Add(6);
            int r = mrd.FuncLista1(l);
            Console.WriteLine(r);
            List<double> num = new List<double>();
            for (int i = 0; i <= 100; i++)
                num.Add(i);
            int s = mrd.FuncLista2(num);
            Console.WriteLine(s);
        }
    }
}