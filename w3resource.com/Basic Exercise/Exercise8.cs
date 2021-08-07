using System;

public class Exercise8
{
    public static void Main()
    {
        Console.WriteLine("Enter the First Number:");
        int Table = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Table of {0} :",Table);
        for (int i = 1;i<= 10;i++)
        {
            Console.WriteLine("{0}",Table*i);
        }
    }
}
