using System;

namespace DamLibTest
{
    public class SetTest
    {
        //public class Test1Results
        //{
        //    public bool Empty1 { get; set; }
        //    public int Count1 { get; set; }
        //    public bool Contains1 { get; set; }
        //    public bool EmptyJuan { get; set; }
        //    public bool CountJuan { get; set; }
        //    public bool ContainsJuan { get; set; }
        //    public bool EmptyJuan2 { get; set; }
        //    public bool CountJuan2 { get; set; }
        //    public bool ContainsJuan2 { get; set; }
        //    public bool EmptyAna { get; set; }
        //    public bool CountAna { get; set; }

        //}
        //public static void Test1(DamLib.Set<string> set)
        //{
        //    Test1Results results = new Test1Results();
        //    {
        //        results.Empty1 = set.Empty;
        //        results.Count1 = set.Count;
        //        //DamLib.Set<string>.Add();
        //        //results.Contains1 = set.Contains();
        //    }

        //}
        static void Main(string[] args)
        {
            DamLib.Set<string> set1 = new DamLib.Set<string>();
            set1.Add("Jose Mari");
            set1.Add("Jose Manuel");
            set1.Add("Josetrix");
            set1.PrintSet();
        }
    }
}