using System;
namespace ReferenceValueType
{
    class RVTClass
    {
        static void Main()
        {
            //Value Type 
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine("A: {0} B: {1}", a, b);
            Console.WriteLine();

            //References Type
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine("Array1: {0} Array2: {1}", array1[0], array2[0]);
            Console.WriteLine();
        }
    }
}
