using System;
using System.Collections.Generic;
namespace UdmyExe68_5NS
{
    public class UdmyExe68_5Class
    {
        static void Main()
        {
            Console.WriteLine("Enter a word to pascal :");
            var input = Console.ReadLine().ToLower();
            var count = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            int Counter = 0;
            foreach (var k in input)
            {
                if (count.Contains(k))
                {
                    Counter++;
                }
            }
            Console.WriteLine(Counter);
        }
    }
}

