using System;
using System.Collections;
using System.Text;

namespace Day6
{
    class Program
    {
        public static void Main()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add("3");
            arrayList.Add('a');
            foreach(var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}