using System;
namespace VRNS
{
    public class Person
    {
      public int Age;
    }

    class Program
    {
        static void Main()
        {
            int number = 1;
            Increment(number);
            Console.WriteLine(string.Format("Number: {0}",number));
            Console.WriteLine();

            var man = new Person() { Age = 10 };
            Make_Old(man);
            Console.WriteLine(string.Format("Age: {0}", man.Age));
            Console.WriteLine();
         }
        public static void Increment(int n)
        {
            n = n + 10;
            //Console.WriteLine(string.Format("n: {0}", n));

        }
        public static void Make_Old(Person man)
        {
            man.Age += 10;
        }


    }
}
