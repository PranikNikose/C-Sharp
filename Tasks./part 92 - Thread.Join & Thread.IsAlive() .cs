using System;
using System.Threading;

class Pgm
{
    static void Main()
    {
        Console.WriteLine("Main Started ");

        Thread t1 = new Thread(Function1Thread);
        t1.Start();
        Thread t2 = new Thread(Function2Thread);
        t2.Start();

        if (t1.Join(1000))
        {
            Console.WriteLine("Function1Thread Completed");
        }
        else
        {
            Console.WriteLine("Function1Thread did not Completed in 1 sec");
        }

        t2.Join();
        Console.WriteLine("Function2Thread Completed");

        Console.WriteLine("Main Completed ");

        if (t1.IsAlive)
        {
            Console.WriteLine("Function1Thread is still working");
        }
        else
        {
            Console.WriteLine("Function1Thread Completed");
        }
    }

    static void Function1Thread()
    {
        Console.WriteLine("Function1Thread Started");
        Thread.Sleep(5000);
        Console.WriteLine("Func 1 thread is about to return");
    }
    static void Function2Thread()
    {
        Console.WriteLine("Function2Thread Started");
    }
}
