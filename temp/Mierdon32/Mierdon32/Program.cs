using System.Collections;
using System.Security.Cryptography;

namespace Mierdon32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> l = new List<int>();
            //l.Add(0);
            //l.Add(1);
            //l.Add(5);
            //l.Add(12);
            //int r = mrd.FuncLista1(l);
            //Console.WriteLine(r);


            //List<double> num = new List<double>();
            //for (int i = 0; i <= 100; i++)
            //    num.Add(i);
            //int s = mrd.FuncLista2(num);
            ////Console.WriteLine(s);
            ////s = mrd.FuncLista2(num);

            //Obamium obama = new Obamium();
            //obama.name = "obama";
            //obama.age = "32";
            //obama.DNI = "043555095W";

            //int r1 = mrd.PrimosHasta(38);
            //Console.WriteLine(r1);
            static void AddArrayRnd(int n1)
            {
                Random r = new Random();
                int n2 = 1;
                int n3 = 1;
                int[] a = new int[n1];
                for (int i = 0; i < n1; i++)
                {
                    a[i] = r.Next(n1);
                }
            }
            bool r1 = mrd.Contains(200);
            Console.WriteLine(r1);
        }
    }
}