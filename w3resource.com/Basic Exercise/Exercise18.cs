using System;
namespace skd
{
    public class Exercise18
    {
        public static void Main()
        {
            int a = -5;
            int b = 25;

            Console.WriteLine(CheckNegative(a, b)    );        
        }

        public static bool CheckNegative(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                return true;
            }
            else
            {
                return false; ;
            }
        }
    }
}
