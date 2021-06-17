using System;
namespace TypeConversionNS
{
    class TypeConversionClass
    {
        static void Main(string[] argv)
        {
            //Implicit Type Conversion
            byte b = 1;
            int i = b;
            Console.WriteLine("Implicit Byte to Int: {0}", i);
      
            //Explicit Type Conversion
            float f = 1.23f;
            int num = (int)f;
            Console.WriteLine("Explicit Float to Int: {0}", num);
      
            //Non-Compatible type
            // 1. Convert Method
            string s1 = "1234";
            int no1 = Convert.ToInt32(s1);
            Console.WriteLine("Non-Compatible: 1.Convert Method = {0}", no1);

            // 2. Parse Method
            string s2 = "4321";
            int no2 = int.Parse(s2);
            Console.WriteLine("Non-Compatible: 2.Parse Method = {0}", no2);
        }
    }
}
