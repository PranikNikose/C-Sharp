using System;
using System.Collections.Generic;

namespace ListSortNS
{
    public class ListSortClass
    {
        static  void Main()
        {
            var list1 = new List<int>();

            for (var i = 0; i <5; i++)
            {
                Console.WriteLine("Enter a Name:");
                var Num = int.Parse(Console.ReadLine());

                if (list1.Contains(Num))
                {
                    Console.WriteLine("Error and Retry" + Num);
                    i--;
                    continue;
                }
                list1.Add(Num);
            }
            list1.Sort();
            foreach (var k in list1)
                Console.WriteLine(k);
        }
    }
}
