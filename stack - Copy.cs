using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Program
    {
        public static void Main()
        {
            //LIFO
            Stack<string> vs = new Stack<string>();
            vs.Push("Diviyani");
            foreach(var item in vs)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}