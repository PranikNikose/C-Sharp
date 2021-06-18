using System;
namespace ExeNS
{
    class ExeClass
    {
        static void Main()
        {
            //exe-1. count how many numbers between 1 and 100 are divisible by 3
            int count = 0;
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Count : {0}",count);

            
        }
    }
}
