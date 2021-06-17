using System;
namespace OperatorsNS
{
    class OperatorsClass
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 3;
            Console.WriteLine();

            //Arithmatic Operators
            Console.WriteLine("Addition: {0}", a + b);
            Console.WriteLine("Subtraction: {0}", a - b);
            Console.WriteLine("Multiplication: {0}", a * b);
            Console.WriteLine("Division: {0}", a / b);
            Console.WriteLine("Remainder: {0}", a % b);
            Console.WriteLine();

            //Relational Operator
            Console.WriteLine("is a>b : {0} ", a > b);
            Console.WriteLine("is a<b : {0} ", a < b);
            Console.WriteLine();

            //Logical Opeartor
            Console.WriteLine("Logical AND : {0}",a > b && b < a );
            Console.WriteLine("Logical OR : {0}", a < b || b > a);
            Console.WriteLine("Logical XOR : {0}", a > b ^ b > a);
            Console.WriteLine();

            //Bitwise Operators
            Console.WriteLine("AND Bitwise : {0} ",a & b);
            Console.WriteLine("OR Bitwise : {0} ", a | b);
            Console.WriteLine("XOR Bitwise : {0} ", a ^ b);
            Console.WriteLine();

        }
    }
}
