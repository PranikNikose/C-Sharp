using System;
public class Exercise5
{
    public static void Main()
    {
        int FN = 20;
        int SN = 30;
        int temp;

        temp = FN;
        FN = SN;
        SN = temp;
        Console.WriteLine("FN : {0}", FN);
        Console.WriteLine("SN : {0}", SN);
    }
}
