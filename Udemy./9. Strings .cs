using System;
namespace StringNS
{
    class StringClass
    {
        static void Main()
        { 
            //by using String Lateral
            string FirstName = "Pranik";
            string LastName = "Nikose";

            //by using String Concatenation
            string FullName = FirstName + " " + LastName;
            Console.WriteLine(FullName);
            Console.WriteLine();

            //by using String Format
            string CompleteName = string.Format("The Full Name is: {0} {1}", FirstName, LastName);
            Console.WriteLine(CompleteName);
            Console.WriteLine();

            //by using string Join
            var names = new string[3] { "Pranik", "Keval", "Nikose"};
            string StudentName = string.Join(",", names);
            Console.WriteLine(StudentName);
            Console.WriteLine();

            //escape character
            Console.WriteLine("Hi Buddy\nPlz Check this Paths:\nC:\\Project1\\folder1");
            Console.WriteLine();

            //verbatim String
            Console.WriteLine(@"Hi Buddy
Plz Check this Paths:
C:\Project1\folder1");
            Console.WriteLine();

        }
    }
}
