using System;
namespace ShippingSystem
{
    public enum DTDC
    {
        Regular = 1,
        Fast = 2,
        Express = 3
    }
    class program
    {
        static void Main()
        {
            var method = DTDC.Express;
            Console.WriteLine(method);
            Console.WriteLine((int)method);

            var ID = 2;
            Console.WriteLine((DTDC)ID);

            Console.WriteLine(method.ToString());

            var MN = "Regular";
            var ShipMet = (DTDC)Enum.Parse(typeof(DTDC), MN);
            Console.WriteLine(ShipMet);

        }
    }
}
