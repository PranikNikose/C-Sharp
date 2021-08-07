using System;
namespace skd
{
    public class Exercise24
    {
        public static void Main()
        {
            string str = "Write a C# Sharp Program to display the following pattern using the alphabet.";

            string[] words = str.Split(new[] {" "}, StringSplitOptions.None);
            string lonword = "";
            int len = 0;
            foreach (string s in words)
            {
                if (s.Length>len)
                {
                    lonword = s;
                    len = s.Length;
                }
            }
            Console.WriteLine(lonword);
        }
    }
}
