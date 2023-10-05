using System.Collections;
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
            static void AddArray(int n1)
            {
                int n2 = 1;
                int n3 = 1;
                int[] a = new int[n1];
                for (int i = 0; i < n1; i++)
                {
                    a[i] = i;
                }
                int num;
                Console.ReadLine(num);
                public static bool Contains(int num)
                {
                    int min = 0;
                    int max = a.Length - 1;
                    int mid = 0;
                    while (min <= max)
                    {
                        mid = (min + max) / 2;
                        if (a[mid] == num)
                            return true;
                        if (num >= a[mid])
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
                mrd.AddArray(200);
        }
    }
}