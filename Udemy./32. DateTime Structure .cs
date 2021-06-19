using System;
using System.Collections.Generic;
namespace ListSortNS
{
    public class ListSortClass
    {
        static void Main()
        {
            Console.WriteLine();
            var k = new DateTime(2020, 7, 29);

            //to get the todays date 
            var Todays = DateTime.Today;
            Console.WriteLine(Todays);
            Console.WriteLine("Date : " + Todays.Day);
            Console.WriteLine("Month : " + Todays.Month);
            Console.WriteLine("Year : " + Todays.Year);
            Console.WriteLine();

            //to get the Real- Time
            var Now =  DateTime.Now;
            Console.WriteLine(Now);
            Console.WriteLine("Hour : "+ Now.Hour);
            Console.WriteLine("Minutes : " + Now.Minute);
            Console.WriteLine("Seconds : "+ Now.Second);
            Console.WriteLine();

            //to go to tommorow (Future) using real-time
            var tommo = Now.AddDays(1);
            Console.WriteLine("Tommorow : "+ tommo);
            Console.WriteLine();

            //to go to yesterday (Past) using Real time
            var yest = Now.AddDays(-1);
            Console.WriteLine("Yesterday : "+ yest);
            Console.WriteLine();

            //To print Long and Short Date and Time Components / strings
            Console.WriteLine(Now.ToLongDateString());
            Console.WriteLine(Now.ToShortDateString());
            Console.WriteLine(Now.ToLongTimeString());
            Console.WriteLine(Now.ToShortDateString());
            Console.WriteLine();

            //to get Date and Time In Long String
            Console.WriteLine(Now.ToString());
            Console.WriteLine();

            //Format Specifiers using ToString()
            Console.WriteLine(Now.ToString("dd-MM-yyyy hh:m:ss tt"));


        }
    }
}

