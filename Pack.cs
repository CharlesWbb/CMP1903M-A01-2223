using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
	class Pack
	{

		static string[] deckOfCards = new string[52];
		static int numberOfCardsDealt = 0;
		public string[] InitialiseCardPack()
		{
			//Initialise the card pack here
			Card card = new Card();
			int deckIndex = 0; //Keeps track of the position a new card needs to be placed within deckOfCards

			for (int suit = 0; suit <= 3; suit++)
			{
				for (int value = 1; value <= 13; value++)
				{
					deckOfCards[deckIndex] = card.Suit[suit].ToString() + " " + value.ToString(); //
					deckIndex++;

				}
			}
			return deckOfCards;
		}

		





		public bool shuffleCardPack(char typeOfShuffle) //changed template from int typeOfShuffle to string.
			//removed static so I can access it from main. 
		{
			//Shuffles the pack based on the type of shuffle
			Random rnd = new Random();


			if (typeOfShuffle == '1')
			{
				Console.WriteLine("Shuffling with Fisher yates");


				for (int i = deckOfCards.Length - 1; i > 0; i--)
				{
					int rndIndex = rnd.Next(0, i);

					string temp = deckOfCards[i];
					deckOfCards[i] = deckOfCards[rndIndex];//swaps positions
					deckOfCards[rndIndex] = temp;



				}


			}
			else if (typeOfShuffle == '2')
			{
				// Perform riffle shuffle
				Console.WriteLine("Performing Riffle Shuffle");

				// Divide the deck into top and bottom halves
				string[] topHalf = deckOfCards.Take(26).ToArray();
				string[] bottomHalf = deckOfCards.Skip(26).ToArray();
				string[] shuffledDeck = new string[52];

				// Keeps track of the current index in each half of the deck
				int topIndex = 0;
				int bottomIndex = 0;

				for (int i = 0; i < 52; i++)
				{
					if (i % 2 == 0)
					{
						shuffledDeck[i] = topHalf[topIndex];
						topIndex++;
					}
					else
					{
						shuffledDeck[i] = bottomHalf[bottomIndex];
						bottomIndex++;
					}
				}

				// Update the original deck with the shuffled deck
				deckOfCards = shuffledDeck;
			}
			else if ((typeOfShuffle == '3'))
			{
				Console.WriteLine("No shuffle");
			}

			/*foreach (var item in deckOfCards)
			{
				Console.WriteLine(item);
			}*/

			return true;


		}
		public void deal()
		{
			Console.WriteLine(deckOfCards[numberOfCardsDealt]);
			numberOfCardsDealt++;

		}
		public void dealCard(int amount)
		{
			//Deals the number of cards specified by 'amount'
			if (amount <= deckOfCards.Length) 
			{
				for (int i = 0; i < amount; i++)
				{
					Console.WriteLine(deckOfCards[i]);

				}			
			}
		}

	}
}
