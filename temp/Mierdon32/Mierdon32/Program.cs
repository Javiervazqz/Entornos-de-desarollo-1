using System.Collections;
using System.Security.Cryptography;

namespace Mierdon32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> l = new List<int>();
            l.Add(-2);
            l.Add(8);
            l.Add(-1);
            l.Add(8);
            l.Add(-1);
            string r1 = mrd.LowerThanZeroPos(l);
            Console.WriteLine(r1);


            //List<double> num = new List<double>();
            //for (int i = 0; i <= 100; i++)
            //    num.Add(i);
            //int s = mrd.MediaArit(l);
            //Console.WriteLine(s);
            //s = mrd.FuncLista2(num);

            //Obamium obama = new Obamium();
            //obama.name = "obama";
            //obama.age = "32";
            //obama.DNI = "043555095W";

            //int r1 = mrd.PrimosHasta(38);
            //Console.WriteLine(r1);
            //    static void AddArrayRnd(int n1)
            //    {
            //        Random r = new Random();
            //        int n2 = 1;
            //        int n3 = 1;
            //        int[] a = new int[n1];
            //        for (int i = 0; i < n1; i++)
            //        {
            //            a[i] = r.Next(n1);
            //        }
            //    }
            //    bool r1 = mrd.Contains(200);
            //    Console.WriteLine(r1);
            //}
            //int[] a = new int[10];
            //a[0] = 4;
            //a[1] = 1;
            //a[2] = 5;
            //a[3] = 5;
            //a[4] = 5;
            //a[5] = 5;
            //a[6] = 3;
            //a[7] = 21;
            //a[8] = 18;
            //a[9] = 44;
            //mrd.RemoveElement0array(a, 5);
            //int[] r1 = mrd.Sort(a);
            //for (int i = 0; i <= a.Length - 1; i++)
            //{
            //    Console.Write(a[i] + " ");
            //}
        }
    }
}