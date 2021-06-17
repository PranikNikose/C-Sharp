using System;

namespace ArrayNS
{
    class ArrayClass
    {
        static void Main()
        {
            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine();

            var flag = new bool[3];
            flag[0] = true;
            Console.WriteLine(flag[0]);
            Console.WriteLine(flag[1]);
            Console.WriteLine(flag[2]);
            Console.WriteLine();


            var names = new string[] { "Pranik" ,"Keval" ,"Nikose" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine();
        }       
     }
}
