using System;

public class Exercise6
{
    public static void Main()
    {
        Console.WriteLine("Enter the First Number:");
        int FN = Convert.ToInt32(Console.ReadLine());  

        Console.WriteLine("Enter the Second Number:");
        int SN = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Third Number:");
        int TN = Convert.ToInt32(Console.ReadLine());
       
        Console.WriteLine("Product: {0}", FN*SN*TN);
    }
}
