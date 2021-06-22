
using System;
namespace CoffeeShopNS
{
	public class CoffeeShopClass
	{
		public static void Main()
		{
			int TotalBill = 0;
		Start:
			Console.WriteLine("Which Cofee Do You Want to Buy: 1-Small  2-Medium  3-Large");
			int UserChoice = int.Parse(Console.ReadLine());
			switch (UserChoice)
			{
				case 1:
					//Console.WriteLine("Small Cofee");
					TotalBill += 10;
					break;
				case 2:
					//Console.WriteLine("Medium Cofee");
					TotalBill += 20;
					break;
				case 3:
					//Console.WriteLine("Large Cofee");
					TotalBill += 30;
					break;
				default:
					Console.WriteLine("you entered {0} is invalid", UserChoice);
					goto Start;
			}

		Decision:
			Console.WriteLine("Do You want to buy more cofee: Yes or No");
			string UserDecision =Console.ReadLine();

			switch ( UserDecision.ToLower())
			{
				case "yes":
					goto Start;
				case "no":
					break;
				default:
					Console.WriteLine("you entered {0} is invalid", UserDecision);
					goto Decision;
			}
            Console.WriteLine();
			Console.WriteLine("Thank You For Shopping With Us");
			Console.WriteLine("Your bill is Rs.{0} ", TotalBill);
			Console.WriteLine();
		}
	}
}
