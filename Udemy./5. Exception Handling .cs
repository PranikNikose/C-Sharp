using System;
namespace ExceptionHandlingNS
{
    class ExceptionHandlingClass
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("File Opened");
                var a = "1234";
                byte b = byte.Parse(a);
                Console.WriteLine(b);
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
