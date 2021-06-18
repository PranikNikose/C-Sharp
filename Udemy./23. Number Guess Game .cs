using System;
namespace ExeNS
{
    class ExeClass
    {
        static void Main()
        {
            int Number;
            bool flag =false;

            var R1 = new Random();
            Number = R1.Next(1, 10);
            //Console.Write("Number:{0}",Number);   //<== to view the number unComment this Command
            Console.WriteLine();
            for (int k = 1 ;k <=4;k++)
            {
                Console.WriteLine("Enter a number:");
                string s = Console.ReadLine();
                int x = int.Parse(s);
                if (x == Number)
                {
                    //Console.WriteLine("You Won");
                    flag = true;
                    break;
                }
            }

            if (flag==true)
            { Console.WriteLine("You Won"); }
            else
            { Console.WriteLine("You Lost"); }
		}
	}
}
