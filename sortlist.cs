using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Program
    {
        static void Main()
        {
            //sorted Dictionary
            SortedList sortedList = new SortedList();
            sortedList.Add(1, "Dog");
            sortedList.Add(2, "Cat");
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine("Key is : " +item.Key+"Value is : "+item.Value);
            }
           SortedList<int, string> keyValues = new SortedList<int, string>();
           keyValues.Add(1,"NASA");
           keyValues.Add(2,"ISRO");
           keyValues.Add(3,"CNSA");
           foreach (var item in keyValues)
           {
               Console.WriteLine("RANK is :" +item.Key+ " Value is : "+item.Value);
           }
           
        }
    }
}