using System;
namespace Demo_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("File Opened");
                var a= "1234";
                byte i = byte.Parse(a);
                Console.WriteLine(i);
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Overflow Error");
            }
            finally 
             { 
                Console.WriteLine("File Closed");
             }
        }
    }
}
