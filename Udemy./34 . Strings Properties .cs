using System;
using System.Collections.Generic;
namespace TimeSpanNS
{
    public class TimeSpanClass
    {
        static void Main()
        {
            //trim()
            var S = " Pranik Nikose ";
            Console.WriteLine("Trim : '{0}'",S.Trim());
            Console.WriteLine();

            //ToUpper()
            Console.WriteLine("ToUpper : '{0}'",S.ToUpper());
            //ToLower()
            Console.WriteLine("ToLower : '{0}'", S.ToLower());
            Console.WriteLine();

            //split by using IndexOf
            var index = S.Trim().IndexOf(" ");
            var Name = S.Trim().Substring(0, index);
            var Surname = S.Trim().Substring(index+1);
            Console.WriteLine("Name: "+ Name);
            Console.WriteLine("Surname : "+ Surname);
            Console.WriteLine();

            //Split()
            var N1 = S.Trim().Split(' ');
            Console.WriteLine("FN :"+ N1[0]);
            Console.WriteLine("SN :" + N1[1]);
            Console.WriteLine();

            //replacing
            Console.WriteLine(S.Replace("Pranik", "PKN"));

            //IsNullOrWhitespace
            if(String.IsNullOrWhiteSpace(S))
                Console.WriteLine("Invalid");

            var P = "25";
            Console.WriteLine(Convert.ToInt32(P));

            var k = 29.95f;
            var j = k.ToString();
            Console.WriteLine("Float to string : "+ j);
            var l = k.ToString("C");
            Console.WriteLine("Float to Currency : " + l);

        }
    }
}

