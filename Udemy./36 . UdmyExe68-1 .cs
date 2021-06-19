using System;
using System.Collections.Generic;
namespace UdmyExe68_1NS
{
    public class UdmyExe68_1Class
    {
        static void Main()
        {
            Console.WriteLine("Enter a few Words:");
            var input = Console.ReadLine();
            
            var list1 = new List<int>();
            foreach(var k in input.Split('-'))
            {
                int x = Convert.ToInt32(k);
                list1.Add(x);
            }
            bool IsConsecutive = false;
            for (int j=1 ;j<list1.Count;j++)
            {
                if (list1[j] != (list1[j-1]) + 1)
                    IsConsecutive = true;
                else
                    IsConsecutive = false;
            }
            if (IsConsecutive)
                Console.WriteLine("no-Consecutive");
            else
                Console.WriteLine("Consecutive");

            foreach (var i in list1)
                Console.WriteLine(i);
        }
    }
}

