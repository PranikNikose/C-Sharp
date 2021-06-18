using System;
namespace ArrayNS
{
    class ArrayClass
    {
        static void Main()
        {
            var A1 = new int[6] { 8, 4, 3, 2, 5, 6};

            //Length
            Console.WriteLine("Length: {0} ", A1.Length );
            Console.WriteLine();

            //IndxOf()
            var index = Array.IndexOf(A1, 5);
            Console.WriteLine("index:"+ index);
            Console.WriteLine();

            //copy()
            var A2 = new int[5];
            Array.Copy(A1, A2, 5);
            Console.WriteLine("Effect of copy():");
            foreach (var n in A2)
                Console.WriteLine(n);
            Console.WriteLine();

            //sort
            Array.Sort(A1);
            Console.WriteLine("Effect of sort():");
            foreach (var n in A1)
                Console.WriteLine(n);
            Console.WriteLine();

            //reversed
            Array.Reverse(A1);
            Console.WriteLine("Effect of Reversed():");
            foreach (var n in A1)
                Console.WriteLine(n);
            Console.WriteLine();

            //clear
            Array.Clear(A1, 0, 3);
            Console.WriteLine("Effect of Clear():");
            foreach (var n in A1)
                Console.WriteLine(n);
            Console.WriteLine();
        }
    }
}
