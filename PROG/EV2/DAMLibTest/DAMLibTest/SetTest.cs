using System;

namespace DamLibTest
{
    public class SetTest
    {
        static void Main(string[] args)
        {
            DamLib.Set<string> s = new DamLib.Set<string>();
            s.Add("juan");
            s.Add("roberto");
            s.Add("alberto");
            s.Add("javi");
            s.Remove("javi");
            s.PrintSet();
        }
    }
}
