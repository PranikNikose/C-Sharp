using System;
namespace WhileLoopNS
{
    class WhileLoopClass
    {
        static void Main()
        {
            //print bo between 1-10 even number 
            int i = 1;
            while (i <= 10)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            Console.WriteLine();

            //for a infinite type
            while (true)
            {
                Console.WriteLine("Your name: ");
                string s = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(s))
                    break;
                else
                    Console.WriteLine("@Repeat " + s);
            }

        }
    }
}
