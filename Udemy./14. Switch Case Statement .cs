using System;
namespace SwitchCaseNS
{   
    public enum Season
    {
        Summer,
        Winter,
        Rainy
    }

    class SwitchCaseClass
    {
    static void Main()
        {
            Console.WriteLine();
            string role = "Admin"; 
            switch (role)
            {
                case "Admin":
                    Console.WriteLine("Admin is here");
                    break;

                case "Mod":
                    Console.WriteLine("Moderator there");
                    break;
            }
            Console.WriteLine();

            var s1 = Season.Summer;
            switch (s1)
            {
                case Season.Summer:
                    Console.WriteLine("This is Summer");
                    break;
                case Season.Winter:
                    Console.WriteLine("This is Winter");
                    break;
                case Season.Rainy:
                    Console.WriteLine("This is Rainy");
                    break;
            }
            Console.WriteLine();

        }
    }
}
