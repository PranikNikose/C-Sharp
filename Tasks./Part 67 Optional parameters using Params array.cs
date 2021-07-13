class MyClass  
{
    public static void Main()
    {  
        Sum.AddNumber(10, 40); 
    }
}
class Sum  
{
    public static void AddNumber(int FN,int SN,params object[] RestOfNumber)   
    {
        int result = FN + SN;
        if(RestOfNumber!=null)
        {
            foreach (int k in RestOfNumber)
            {   
                result += k;  
            }
            System.Console.WriteLine("Result= "+result);        
        }
    }
}
