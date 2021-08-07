using System;
namespace skd
{
    public class Exercise17
    {
        public static void Main()
        {
            string s1 = "The quick brown fox jumps over the lazy dog.";

            Console.WriteLine(AddFirstCharToStartAndEnd(s1));
        }

        public static string AddFirstCharToStartAndEnd(string str)
        {
            if (str.Length>1)
            {
                return str.Substring(0,1) + str.Substring(0, str.Length) + str.Substring(0,1);
            }
            else
            {
                return str;
            }
        }
    }
}
