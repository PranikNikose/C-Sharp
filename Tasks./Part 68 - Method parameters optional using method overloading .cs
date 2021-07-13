class MyClass
{
    public static void Main()
    {
        Sum.AddNumber(30, 40);
    }
}
class Sum
{
    public static void AddNumber(int FN, int SN)
    {
        Sum.AddNumber(FN, SN, null);
    }
    public static void AddNumber(int FN, int SN, int[] RestOfNumber)
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
