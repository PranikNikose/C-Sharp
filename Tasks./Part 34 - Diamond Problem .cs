using System;

class A
{ 
    public virtual void Print()
    {
        Console.WriteLine("Hello");
    }
}
class B:A
{
    public override void Print()
    {
        Console.WriteLine("Hello");
    }
}

class C:A
{
    public override void Print()
    {
        Console.WriteLine("Hello");
    }
}

class D:B,C
{
}

class Program
{
    static void Main()
    {
        D obj = new D();
        obj.Print();
    }
}
