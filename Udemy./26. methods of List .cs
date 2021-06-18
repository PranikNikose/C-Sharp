using System;
using System.Collections.Generic;  //for using the list 

namespace ListNS
{ 
    class ListClass
    {
        static void Main()
        {
            var list1 = new List<int>() { 1, 2, 3, 4, 5, 6 };

            //To add Single Element to the list
            list1.Add(7);

            //to add list or array to th list
            list1.AddRange(new int[3] { 8, 9, 1 });

            foreach (var n in list1)
                Console.WriteLine(n);
            Console.WriteLine();

            //IndexOf()
            int index = list1.IndexOf(1);
            Console.WriteLine("Index of 1 :"+index);
            Console.WriteLine();

            //LastIndexOf
            int LastIndex = list1.LastIndexOf(1);
            Console.WriteLine("LastIndex of 1 :" + LastIndex);
            Console.WriteLine();

            //Count of list
            int count = list1.Count;
            Console.WriteLine("count of list:" + count);
            Console.WriteLine();

            //to remove first element from list 
            list1.Remove(1);

            //to remove all elements having 1 element
            for (int i=0;i<=list1.Count;i++)
            {
                if (list1[i] == 1)
                    list1.Remove(list1[i]);
            }
            foreach(var n in list1)
                Console.WriteLine(n);
            Console.WriteLine();

            //to clear the list 
            list1.Clear();
            Console.WriteLine("Count after Clear : "+list1.Count);
        }
    }
}
