using System;
interface I1
{
    void InterfaceMethod();
}

interface I2
{
    void InterfaceMethod();
}

class myClass :I1,I2
{
    void I1.InterfaceMethod()
    {
        Console.WriteLine("I1 method In Interface");
    }
    void I2.InterfaceMethod()
    {
        Console.WriteLine("I2 method In Interface");
    }
}

class Program
{
    static void Main()
    {
        myClass c1 = new myClass();
        ((I1)c1).InterfaceMethod();
        ((I2)c1).InterfaceMethod();

    }
}
