using System;
namespace Exercise1_4
{
    class Exe1_4
    {
        static void Main()
        {
            //Excersice-4
            Console.WriteLine("enter the speed limit:");
            int SpeedLimit = int.Parse(Console.ReadLine());    //Limit

            Console.WriteLine("enter the speed of car:");
            int SpeedOfCar = int.Parse(Console.ReadLine());      //Actual speed of car

            //Exercise4 by using nested if else
            if (SpeedOfCar < SpeedLimit)
                Console.WriteLine("OK");
            else
            {
                const int demerit5kmphr = 5;
                int result = (SpeedOfCar - SpeedLimit) / demerit5kmphr;
                if (result>12)
                    Console.WriteLine("Licenses cancel");
                else
                    Console.WriteLine("Demerit:"+ result);
            }
            Console.WriteLine();
            }
        }
    }

