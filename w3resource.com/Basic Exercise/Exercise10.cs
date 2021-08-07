using System;

public class Exercise10
{
    public static void Main()
    {
        Console.WriteLine("Enter the First Number:");
        int X = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the First Number:");
        int Y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the First Number:");
        int Z = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("(X + Y)*Z :{0}", (X + Y)*Z);
        Console.WriteLine(" X * Y + Y * Z :{0}", X * Y + Y * Z);
    }
}
