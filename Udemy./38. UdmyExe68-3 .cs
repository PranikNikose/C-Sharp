using System;
using System.Collections.Generic;
namespace UdmyExe68_3NS
{
    public class UdmyExe68_3Class
    {
        static void Main()
        {
            Console.WriteLine("Enter a time :");
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var Compo = input.Split(':');

            var hour = Convert.ToInt32(Compo[0]);
            Console.WriteLine("hour: "+ hour);
            var min = Convert.ToInt32(Compo[1]);
            Console.WriteLine("min: " + min);

            if (hour >= 0 && hour <= 23 && min >= 0 && min < 60) 
                Console.WriteLine("OK");
            else
                Console.WriteLine("Invalid Time");

        }
    }
}

