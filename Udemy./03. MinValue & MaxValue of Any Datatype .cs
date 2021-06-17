using System;
namespace MinMaxNs
{
    class MinMaxClasss
    {
        static void Main(string[] argv)
        {
            Console.WriteLine("Byte range: {0} to {1}", byte.MinValue,byte.MaxValue);
            Console.WriteLine("Short range: {0} to {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("Int range: {0} to {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("Long range: {0} to {1}", long.MinValue, long.MaxValue);
            Console.WriteLine();

            Console.WriteLine("float range: {0} to {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("double range: {0} to {1}", double.MinValue, double.MaxValue);
            Console.WriteLine("decimal range: {0} to {1}", decimal.MinValue, decimal.MaxValue);
            Console.WriteLine();
        }
    }
}
