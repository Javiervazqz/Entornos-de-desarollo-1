using System;

namespace DamLibTest
{
    public class QueueTest
    {
        static void Main(string[] args)
        {
            DamLib.Queue<string> q = new DamLib.Queue<string>();
            q.ToQueue("Jose Mari");
            q.ToQueue("Jose Manuel");
            q.ToQueue("Josetrix");
            q.DeQueue();
            q.PrintQueue();
        }
    }
}
