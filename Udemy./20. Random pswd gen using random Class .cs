using System;
namespace RandomNS
{
    class RandomClass
    {
        static void Main()
        {
            const int PassWordLength = 10;
            var r1 = new Random();
            var char1 = new char[PassWordLength];
            for (int i = 0; i < PassWordLength; i++)
            { 
                char1[i]= (char)r1.Next(97, 122);  //97=a  122=z
            }
            string Passwd = new string(char1);
            Console.WriteLine(Passwd);
                
            //Console.WriteLine((int)'a');
            //Console.WriteLine();


        }
    }
}
