using System;
namespace skd
{
    public class Exercise21
    {
        public static void Main()
        {

            Console.WriteLine("{0}", Check20OrSum20(25, 20));
        }

        public static bool Check20OrSum20(int FN, int SN)
        {
            int sum = FN + SN;
            if (FN==20 || SN==20|| sum==20)
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
