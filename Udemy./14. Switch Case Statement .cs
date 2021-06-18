using System;
namespace SwitchCaseNS
{
    class SwitchCaseClass
    {
    static void Main()
        {
            string role = "Admin"; 
            switch (role)
            {
                case "Admin":
                    Console.WriteLine("Admin is here");
                    break;

                case "Mod":
                    Console.WriteLine("I am Moderator");
                    break;
            }
        }
    }
}
