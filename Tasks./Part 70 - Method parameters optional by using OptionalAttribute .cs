using System;
using System.Runtime.InteropServices;
class MyClass
{
    public static void Main()
    {
        Sum.AddNumber(30,60,new int[] { 1,2,3,4,5,6});
    }
}
class Sum
{
    public static void AddNumber(int FN, int SN, [Optional] int[] RestOfNumber)
    {
        int result = FN + SN;
        if (RestOfNumber != null)
        {
            foreach (int k in RestOfNumber)
            {
                result += k;
            }
        }
        System.Console.WriteLine("Result= " + result);
    }
}
