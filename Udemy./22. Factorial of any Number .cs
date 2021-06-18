using System;
namespace ExeNS
{
    class ExeClass
    {
        static void Main(string[] argv)
        {
            int d = 1;
            Console.WriteLine("Enter a number:");
            string s = Console.ReadLine();
            int n = int.Parse(s);
            for (var i=1;i<=n;i++)
            {
                d = d * i;
            }
            Console.WriteLine("Factorial of {0} is {1}",n,d);
		}
	}
}
