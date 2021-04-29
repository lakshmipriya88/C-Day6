using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Program
    {
        public static void Main()
        {
            //{1,2,3}
            HashSet<int> ts1 = new HashSet<int>();
            ts1.Add(1); ts1.Add(2); ts1.Add(3);
            
            //{1,2}
            HashSet<int> ts2 = new HashSet<int>();
            ts2.Add(1); ts2.Add(2); 
            Console.WriteLine(ts2.IsSubsetOf(ts1));
            //foreach (var item in ts)
           // {
            //    Console.WriteLine(item);
            //}
           Console.ReadLine();
        }
    }
}