using System.IO;
using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    
    {
        List<int> mylist = new List<int>();
        for (int i=5; i<10; i++)
        {
            mylist.Add(i*2);
        }
        foreach (var item in mylist)
        {
            Console.WriteLine(item);
        }
        Console.ReadLine();
    }
}