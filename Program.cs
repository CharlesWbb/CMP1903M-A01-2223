using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
			Pack pack = new Pack();
			UserInput input = new UserInput();
			char userInput = ' ';
			char userInputCardDeal = ' ';
			pack.InitialiseCardPack();



			Console.WriteLine("Please enter one of the following:");
			Console.WriteLine("Enter '1': for Fisher yates Shuffle: ");
			Console.WriteLine("Enter '2': for Riffle Shot Shuffle: ");
			Console.WriteLine("Enter '3': for no shuffle: ");

			userInput = input.ExceptionCheck();
			while (true)
			{
				if (userInput == '1' | userInput == '2' | userInput == '3')
				{
					Console.WriteLine("\nInput is valid \n");
					break;
				}
				else
				{
					Console.WriteLine("You did not enter either '1' or '2'. Please try again");
					userInput = input.ExceptionCheck();
				}
			}

			pack.shuffleCardPack(userInput);

			//ask user for many cards or single card

			//
			
			Console.WriteLine("Please enter one of the following:");
			Console.WriteLine("Enter '1': for 1 card to be delt: ");
			Console.WriteLine("Enter '2': for a custom amount of cards to be dealt: ");
			userInputCardDeal = input.ExceptionCheck();

			if (userInputCardDeal == '1')
			{
				pack.deal();
			}
			else if (userInputCardDeal == '2')
			{
				Console.WriteLine("\n Please input how many cards you would like: " +
					"");
				int amount = int.Parse(Console.ReadLine());
				pack.dealCard(amount);

			}


			
						











			Console.ReadKey();
		}

		

		
	}
}
