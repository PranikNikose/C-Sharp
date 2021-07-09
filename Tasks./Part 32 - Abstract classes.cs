using System;

public abstract class Customer
{
    public abstract void Print();
}

public class Program :Customer
{
    public override void Print()
    {
        Console.WriteLine("hello");
    }

    public static void Main()
    {
        Customer c1 = new Program();
        c1.Print();
    }
}
