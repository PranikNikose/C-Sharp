using System;
using System.Collections.Generic;
namespace UdmyExe68_5NS
{
    public class UdmyExe68_5Class
    {
        public static void Main()
        {
            Console.WriteLine("Enter a word to pascal :");
            var input = Console.ReadLine().ToLower();
            Console.WriteLine(GetVowels(input));
           
        }
        public static int GetVowels(string input)
        {
            var count = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            int Counter = 0;
            foreach (var k in input)
            {
                if (count.Contains(k))
                    Counter++;
            }
            return Counter;
        }
    }
}

