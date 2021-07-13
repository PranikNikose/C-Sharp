class MyClass
{
    public static void Main()
    {
        Sum.AddNumber(30,60);
    }
}
class Sum
{
    public static void AddNumber(int FN, int SN, int[] RestOfNumber=null)
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
