using System;

public class Exercise12
{
    public static void Main()
    {
        Console.WriteLine("Enter the First Number:");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int k = 1; k <= 2; k++) 
        { 
            Console.WriteLine("{0} {0} {0} {0}",number);
            Console.WriteLine("{0}{0}{0}{0}", number);
        }
    }
}
