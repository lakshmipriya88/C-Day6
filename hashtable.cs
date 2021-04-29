using System.IO;
using System;
using System.Collections;
using System.Text;

namespace Day6
{
    class Program
    {
        public static void Main()
        {
            Hashtable g = new Hashtable();
            g.Add(1, "Welcome");
            g.Add(2, "to");
            g.Add(3, "C sharp");
            g.Add(4, "class");
            
            ICOllection key = g.Keys;
            foreach(var item in key)
            {
                Console.WriteLine(item+"-"+g[item]);
            }
            Console.ReadLine();
        }
    }
}