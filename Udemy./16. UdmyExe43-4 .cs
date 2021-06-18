using System;
namespace Exercise1_4
{
    class Exe1_4
    {
        static void Main()
        {
            //Excersice-4
            int SpeedLimit = 50;    //Limit
            int SpeedOfCar = 62;     //Actual speed of car

            //Exercise4 by using nested if else
            if (SpeedOfCar < SpeedLimit)
                Console.WriteLine("OK");
            else
            {
                if (SpeedOfCar > 50 && SpeedOfCar <= 55)
                    Console.WriteLine("Demerit 1");
                else if (SpeedOfCar >= 55 && SpeedOfCar <= 60)
                    Console.WriteLine("Demerit 2");
                else if (SpeedOfCar >= 60 && SpeedOfCar <= 65)
                    Console.WriteLine("Demerit 3");
                else if (SpeedOfCar >= 65 && SpeedOfCar <= 70)
                    Console.WriteLine("Demerit 4");
                else if (SpeedOfCar >= 70 && SpeedOfCar <= 75)
                    Console.WriteLine("Demerit 5");
                else if (SpeedOfCar >= 75 && SpeedOfCar <= 80)
                    Console.WriteLine("Demerit 6");
                else if (SpeedOfCar >= 80 && SpeedOfCar <= 85)
                    Console.WriteLine("Demerit 7");
                else if (SpeedOfCar >= 85 && SpeedOfCar <= 90)
                    Console.WriteLine("Demerit 8");
                else if (SpeedOfCar >= 90 && SpeedOfCar <= 95)
                    Console.WriteLine("Demerit 9");
                else if (SpeedOfCar >= 95 && SpeedOfCar <= 100)
                    Console.WriteLine("Demerit 10");
                else if (SpeedOfCar >= 100 && SpeedOfCar <= 105)
                    Console.WriteLine("Demerit 11");
                else
                    Console.WriteLine("Nested If Else: License Suspended");
            }
            Console.WriteLine();

            //by using Switch statement
            if (SpeedOfCar < SpeedLimit)
                Console.WriteLine("OK");
            else
            {
                var demerit = SpeedOfCar;
                switch (demerit)
                {
                    case 55:
                        Console.WriteLine("demerit 1");
                        break;
                    case 60:
                        Console.WriteLine("demerit 2");
                        break;
                    case 65:
                        Console.WriteLine("demerit 3");
                        break;
                    case 70:
                        Console.WriteLine("demerit 4");
                        break;
                    case 75:
                        Console.WriteLine("demerit 5");
                        break;
                    case 80:
                        Console.WriteLine("demerit 6");
                        break;
                    case 85:
                        Console.WriteLine("demerit 7");
                        break;
                    case 90:
                        Console.WriteLine("demerit 8");
                        break;
                    case 95:
                        Console.WriteLine("demerit 9");
                        break;
                    case 100:
                        Console.WriteLine("demerit 10");
                        break;
                    case 105:
                        Console.WriteLine("demerit 11");
                        break;
                    default:
                        //Console.WriteLine("demerit 12");
                        Console.WriteLine("Switch Case : License Cancel");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
