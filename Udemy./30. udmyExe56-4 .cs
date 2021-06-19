using System;
using System.Collections.Generic;

namespace ListSortNS
{
    public class ListSortClass
    {
        static void Main()
        {
            var list1 = new List<int>();
            while (true)
            {
                Console.Write("Enter a number (or 'Quit' to exit): ");
                var input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;

                list1.Add(Convert.ToInt32(input));
            }

            var uniques = new List<int>();
            foreach (var n in list1)
            {
                if (!uniques.Contains(n))
                    uniques.Add(n);
            }

            Console.WriteLine("Unique numbers:");
            foreach (var k in uniques)
                Console.WriteLine(k);
        }
    }
}
