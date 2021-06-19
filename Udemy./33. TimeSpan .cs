using System;
using System.Collections.Generic;
namespace TimeSpanNS
{
    public class TimeSpanClass
    {
        static void Main()
        {
            //Creating
            var TS = new TimeSpan(2, 30, 50);
            Console.WriteLine(TS);
            Console.WriteLine();

            //Same Way
            var TS1 = new TimeSpan(3, 0, 0);
            Console.WriteLine(TS1);
            var TS3 = TimeSpan.FromHours(3);
            Console.WriteLine(TS3);
            Console.WriteLine();

            //
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(3);
            var duration = end - start;
            Console.WriteLine("Duration : " +duration);
            Console.WriteLine();

            //Properties 
            Console.WriteLine("Minutes : "+ TS.Minutes);
            Console.WriteLine("Total Minutes : " + TS.TotalMinutes);
            Console.WriteLine();

            //add and Subtract from original as it is mutable but we can modify in new object
            Console.WriteLine("Add : "+ TS.Add(TimeSpan.FromMinutes(5)));
            Console.WriteLine();
            Console.WriteLine("Sub : " + TS.Subtract(TimeSpan.FromMinutes(3)));
            Console.WriteLine();

            //ToString()
            Console.WriteLine(TS.ToString());
            Console.WriteLine();

            //parse string to time
            Console.WriteLine(TimeSpan.Parse("05:50:45"));
            Console.WriteLine();
        }
    }
}

