using System;
using System.Collections.Generic;
namespace UdmyExe68_2NS
{
    public class UdmyExe68_2Class
    {
        static void Main()
        {
            Console.WriteLine("Enter a few Words new :");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
                return;

            var list1 = new List<int>();
            foreach(var k in input.Split('-'))
            {
                int x = Convert.ToInt32(k);
                list1.Add(x);
            }
            var listofUnique = new List<int>();

            bool Duplicate = true;

            foreach(var k in list1)
            {
                if (!listofUnique.Contains(k))
                    listofUnique.Add(k);
                else
                    Duplicate = false;
            }
            if (Duplicate)
                Console.WriteLine("No Duplicate");
            else
                Console.WriteLine("Duplicate");
        }
    }
}

