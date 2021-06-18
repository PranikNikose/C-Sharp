using System;
namespace ForeachNS
{
    class ForeachClass
    {
        static void Main()
        {
            string s = "PRANIK";

            //For Loop
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
            Console.WriteLine();

            //Foreach Loop sepearting char from string
            foreach (char k in s)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine();

            //For each Seperating Numbers from Array
            int[] array1 = new int[4] { 1, 3, 5, 7 };
            foreach(int n in array1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
        }
    }
}
