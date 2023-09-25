﻿using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace func
{
    internal class Functions
    {
        public static int GetMayor(int n1, int n2)
        {
            if (n1 > n2)
                return n1;
            return n2;
        }
        public static int Summation(int n1)
        {
            int i = 1;
            int j = 0;
            while (i <= n1)
            {
                j += i;
                i++;
            }
            return j;
        }
        public static int Summation2(int n1)
        {
            int j = 0;
            for (int i = 1; i <= n1; i++)
            {
                j += i;
            }
            return j;
        }

        public static bool OddEven(int n0)
        {
            if (n0 % 2 == 0)
                return true;
            return false;
        }
        public static int ParesRaros(int n1)
        {
            for (int n2 = 0; n2 < n1; n2 += 2)
                if (OddEven(n2 / 2))
                    Console.WriteLine(-n2);
                else
                    Console.WriteLine(n2);
            return n1;
        }
        public static bool Prime(int n1)
        {
            for (int i = 2; i < n1; i++)
                if ((n1 % i) == 0)
                    return false;
            return true;
        }
        public static int SeriesLuis(int n1)
        {
            int num = 0;
            for (int i = 1; num <= n1; i++)
            {
                if (OddEven(i))
                {
                    num -= 2;
                    i = -i;
                }
                else
                {
                    num += 5;
                    i = -i;
                }
                if (num >= n1)
                    return n1;
                Console.WriteLine(num);
            }
            return n1;
        }
        public static int MenorTres(int n1, int n2, int n3)
        {
            if ((n1 <= n2) && (n1 <= n3))
                return n1;
            if ((n3 <= n1) && (n3 <= n2))
                return n3;
            return n2;
        }
        public static int MenorTresDos(int n1, int n2, int n3)
        {
            if (n1 <= n2)
                if (n2 <= n3)
                    return n1;
                return n2;
            return n3;
        }
        public static int Productorio(int n1)
        {
            int j = 1;
            for (int i = 1; i <= n1; i++)
            {
                j *= i;
            }
            return j;
        }
    }
}