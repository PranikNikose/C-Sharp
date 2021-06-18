using System;
namespace FindMaxNS
{
    class FindMaxClass
    {
        static void Main()
        {   //Write a program and ask the user to enter a series
            //of numbers separated by comma. Find the maximum
            //of the numbers and display it on the console
            var arr1 = new int[5];
            for (int i=0;i<=4;i++)
            {
                Console.WriteLine("Enter the next value:");
                var s = Console.ReadLine();
                int x = int.Parse(s);
                arr1[i] = x;
            }

            int max = arr1[0];
            foreach (int k in arr1)
            {
                if (k > max)
                {
                    max = k;
                 }
            }       

            Console.WriteLine("Maximum:{0}",max);

        }
    }
}
