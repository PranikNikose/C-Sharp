using System;
namespace skd
{
    public class Exercise22
    {
        public static void Main()
        {

            Console.WriteLine("{0}", checkWithin20(25));
            Console.WriteLine("{0}", checkWithin20(50));
            Console.WriteLine("{0}", checkWithin20(70));
            Console.WriteLine("{0}", checkWithin20(80));
            Console.WriteLine("{0}", checkWithin20(125));
        }

        public static bool checkWithin20(int FN)
        {
            //int sum = FN + SN;
            if (Math.Abs(FN - 100) <=20 || Math.Abs(FN-200)<=20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
