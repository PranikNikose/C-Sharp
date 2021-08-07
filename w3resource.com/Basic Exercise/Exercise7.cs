using System;

public class Exercise7
{
    public static void Main()
    {
        Console.WriteLine("Enter the First Number:");
        int FN = Convert.ToInt32(Console.ReadLine());  

        Console.WriteLine("Enter the Second Number:");
        int SN = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Adding: {0}", FN + SN);
        Console.WriteLine("Substracting: {0}", FN - SN);
        Console.WriteLine("Multiplying: {0}", FN * SN);
        Console.WriteLine("Dividing: {0}", FN / SN);
        Console.WriteLine("Moding: {0}", FN % SN);
    }
}
