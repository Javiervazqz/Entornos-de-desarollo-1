﻿using DamLib;

namespace DamLibTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            DamLib.Stack<string> s = new DamLib.Stack<string>();
            s.Push("Jose Mari");
            s.Push("Jose Manuel");
            s.Push("Josetrix");
            s.Pop();
        }
    }
}