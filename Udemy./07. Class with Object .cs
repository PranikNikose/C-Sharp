using System;
namespace CWO
{
    public class Person
    {
        // Variables in class
        public string FirstName;
        public string Lastname;

        //Methods in class
        public void Introduce()
        {
            Console.WriteLine("My Name is " + FirstName + " " + Lastname);
        }
    }
    class Program
    { 
         static void Main()
         {
                Person MyObj = new Person();
                MyObj.FirstName = "Pranik";
                MyObj.Lastname = "Nikose";
                MyObj.Introduce();


         }
    }

    }
