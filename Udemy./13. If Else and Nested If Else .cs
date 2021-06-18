using System;
namespace IfElseNS
{
    class IfElseClass
    {
        static void Main()
        {
            //if else Statement
            int hour = 10;
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("Its Morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("Its Afternoon");
            }
            else
            {
                Console.WriteLine("Its Evening and Night");
            }
            Console.WriteLine();

            //Nested If Else Statement
            int minute = 30;
            if(hour==10)
            {
                Console.WriteLine("Hour: 10");
                if (minute < 30)
                { 
                    Console.WriteLine("Below 10.30"); 
                }
                else
                { 
                    Console.WriteLine("above 10.30"); 
                }
            }
            
        }
    }
}
