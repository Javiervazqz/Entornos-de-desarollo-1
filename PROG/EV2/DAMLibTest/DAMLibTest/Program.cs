using DamLib;

namespace DamLibTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            //DamLib.Stack<string> s = new DamLib.Stack<string>();
            //s.Push("Jose Mari");
            //s.Push("Jose Manuel");
            //s.Push("Josetrix");
            //s.Pop();
            //Console.WriteLine(s.IsEmpty());
            //s.PrintStack();
            //DamLib.Queue<string> q = new DamLib.Queue<string>();
            //q.ToQueue("Jose Mari");
            //q.ToQueue("Jose Manuel");
            //q.ToQueue("Josetrix");
            //q.DeQueue();
            //q.PrintQueue();
            DamLib.Set<string> s = new DamLib.Set<string>();
            s.Add("juan");
            s.Add("roberto");
            s.Add("alberto");
            s.Add("javi");
            s.Remove("alberto");
            s.PrintSet();
        }
    }
}