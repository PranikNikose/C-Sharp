using System;

public delegate void HelloDelegate(string msg); 

class Myclass
{
    public static void Hello(string strmsg)
    {
        Console.WriteLine(strmsg);
    }
}

class Program
{
    static void Main()
    {
        HelloDelegate obj = new HelloDelegate(Myclass.Hello);
        obj("Hello From Delegate instance");
    }
}
