using System;
namespace Exercise1
{
    class Exe1
    {
        static void Main()
        {   
            //Excersice-1
            int n = 16;
            if (10 > n && n > 0)
            { 
                Console.WriteLine("Valid"); 
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.WriteLine();

            //Excersice-2
            int num1 = 100;
            int num2 = 78;
            if (num1>num2)
                Console.WriteLine("Greater no is : {0}",num1);
            else
                Console.WriteLine("Greater no is : {0}", num2);
            Console.WriteLine();

            //Excersice-3
            int width = 100;
            int Height = 1500; //length
            if (width > Height)
                Console.WriteLine("Landscape");
            else
                Console.WriteLine("Portrait");
            Console.WriteLine();
            
        }

    }
}
