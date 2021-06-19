using System;
using System.Collections.Generic;
namespace UdmyExe68_4NS
{
    public class UdmyExe68_4Class
    {
        static void Main()
        {
            Console.WriteLine("Enter a word to pascal :");
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
                return;
            var result = "";
            foreach (var k in input.Split(' '))
            {
                var pascal = char.ToUpper(k[0]) + k.ToLower().Substring(1)+"";
                result += pascal;
            }
            Console.WriteLine(result);
        }
    }
}

