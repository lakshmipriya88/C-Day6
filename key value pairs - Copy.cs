using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Program
    {
        static void Main()
        {
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(1, "Diviyani");
            keyValuePairs.Add(2, "Diviya");
            keyValuePairs.Add(3, "Dii");
            Console.WriteLine(keyValuePairs[1]);
            foreach(var item in keyValuePairs)
            {
                Console.WriteLine("Key= "+item.Key+"Value+" +item.Value);
            }
            if (keyValuePairs.ContainsKey(12)==true)
            {
                Console.WriteLine("Key Found");
            }
            else
            {
                Console.WriteLine("Key Not Found");
            }
            if(keyValuePairs.ContainsValue("Diviyani"))
            {
                Console.WriteLine("Value Found");
            }
            else
            {
                Console.WriteLine("Value not Found");
            }
        }
    }
}