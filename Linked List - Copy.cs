using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Program
    {
        public static void Main()
        {
            LinkedList<string> vs = new LinkedList<string>();
            
            vs.AddLast("Diviyani");
            vs.AddLast("is");
            vs.AddLast("in");
            vs.AddLast("India");
            
            Console.WriteLine(vs.First.Value);
            Console.WriteLine(vs.Last.Value);
            Console.WriteLine(vs.Contains("India"));
            foreach(var item in vs)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}