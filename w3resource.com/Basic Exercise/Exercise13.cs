using System;

public class Exercise13
{
    public static void Main()
    {
        Console.WriteLine("Enter the First Number:");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("{0}{0}{0}",number);
        Console.WriteLine("{0} {0}", number);
        Console.WriteLine("{0} {0}", number);
        Console.WriteLine("{0} {0}", number);
        Console.WriteLine("{0}{0}{0}", number);
    }
}
