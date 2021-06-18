using System;
namespace ForLoopNS
{
    class ForLoopClasss
    {
        static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i); 
                }
            }
            Console.WriteLine();
            for (int k = 10; k >= 1; k--)
            {
                if (k % 2 == 0)
                {
                    Console.WriteLine(k);
                }
            }
            Console.WriteLine();
        }
    }
}
