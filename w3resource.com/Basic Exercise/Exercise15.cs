using System;
namespace skd
{
    public class Exercise15
    {
        public static void Main()
        {
            //Console.WriteLine("Enter the Degree Celsius:");
            string s = "w3resource";

            Console.WriteLine(RemoveChar(s, 1));

            Console.WriteLine(RemoveChar(s, 9));

            Console.WriteLine(RemoveChar(s, 0));
        }

        public static string RemoveChar(string str, int n)
        {
            return str.Remove(n,1);
        }
    }
}
