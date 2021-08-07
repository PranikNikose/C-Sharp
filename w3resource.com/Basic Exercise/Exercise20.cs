using System;
namespace skd
{
    public class Exercise20
    {
        public static void Main()
        {
           
            Console.WriteLine("Sum :{0}", Abosolute(13,40));
            Console.WriteLine("Sum :{0}", Abosolute(50, 21));
            Console.WriteLine("Sum :{0}", Abosolute(0, 23));
        }

        public static int Abosolute(int FN, int SN)
        {
            if (FN>SN)
            {
                return (FN - SN)*2;
            }
            
                return (FN - SN);
           
        }
    }
}
