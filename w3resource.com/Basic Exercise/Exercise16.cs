using System;
namespace skd
{
    public class Exercise16
    {
        public static void Main()
        {
            string s1 = "w3resource";
            string s2 = "python";
            string s3 = "x";

            Console.WriteLine(ExchangeStringFirstAndLast(s1));
            Console.WriteLine(ExchangeStringFirstAndLast(s2));
            Console.WriteLine(ExchangeStringFirstAndLast(s3));
        }

        public static string ExchangeStringFirstAndLast(string str)
        {
            if (str.Length>1)
            {
                return str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1);
            }
            else
            {
                return str;
            }
        }
    }
}
