using System;
namespace WhileLoopNS
{
    class WhileLoopClass
    {
        static void Main()
        {
            var sum = 0;
            //int num;
            while(true)
            {
                Console.WriteLine("Enter a number:");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;
                else
                {
                    sum = sum + int.Parse(input);
                }
            }
            Console.WriteLine("Sum:"+sum);
        }
    } 
}
