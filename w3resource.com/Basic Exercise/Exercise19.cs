using System;
namespace skd
{
    public class Exercise19
    {
        public static void Main()
        {
           
            Console.WriteLine("Sum :{0}", Sum(2,2));
            Console.WriteLine("Sum :{0}", Sum(12, 10));
            Console.WriteLine("Sum :{0}", Sum(-5, 2));
        }

        public static int Sum(int a, int b)
        {
            if (a == b)
            {
                return (a + b) * 3;
            }
            else
            {
               return  a + b;
            }
        }
    }
}
