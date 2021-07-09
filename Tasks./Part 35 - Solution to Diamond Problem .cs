using System;

interface IA
{
    void aPrint();
}
class A:IA
{
    public void aPrint()
    {
        Console.WriteLine("Hello from Interface A");
    }
}

interface IB
{
    void bPrint();
}
class B:IB
{
    public  void bPrint()
    {
        Console.WriteLine("Hello from Interface B");
    }
}

interface IC
{
    void cPrint();
}
class C:IC
{
    public  void cPrint()
    {
        Console.WriteLine("Hello from Interface C");
    }
}

interface ID
{
    void dPrint();
}
class D:IA,IB
{
    A a1 = new A();
    public void aPrint()
    {
        a1.aPrint();
    }

    B b1 = new B();
    public void bPrint()
    {
        b1.bPrint();
    }

}

class Program
{
    static void Main()
    {
        D obj = new D();
        obj.aPrint();
        obj.bPrint();
    }
}
