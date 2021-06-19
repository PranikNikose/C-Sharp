using System;
using System.Collections.Generic;

namespace FacebookNS
{
    class FacebookClass
    {
        static void Main()
        {
            var list1 = new List <String> ();
            int count = 0;
            while(true)
            {
                Console.WriteLine("Enter a Name:");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    break;
                else
                {
                    list1.Add(input);
                    count++;
                }
            }
            if (count > 2)
                Console.WriteLine(list1[0] + "," + list1[1] + " and " + ((list1.Count)-2) + " Likes Your Post");
            else if (count == 2)
                Console.WriteLine(list1[0] + "and" + list1[1] +" Likes Your Post");
            else if (count == 1)
                Console.WriteLine(list1[0] + " Likes Your Post");
            else
                Console.WriteLine("");
        }
    }
}
