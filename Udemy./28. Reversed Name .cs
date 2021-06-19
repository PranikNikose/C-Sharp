using System;
namespace ReversedNS
{
    public class ReversedClass
    {
        static  void Main()
        {
            Console.WriteLine("Enter a Name:");
            var Name = Console.ReadLine();

            var arr1 = new char[Name.Length];

            for(var i = Name.Length ; i > 0 ; i--)
                arr1[Name.Length - i] = Name[i - 1];

            var reversed = new string(arr1);
            Console.WriteLine("Reversed name: " + reversed);
        }
    }
}
