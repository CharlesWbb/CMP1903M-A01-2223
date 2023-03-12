using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
	class UserInput
	{
		char userInput = ' ';
		bool isInputValidated = false;

		public char ExceptionCheck()
		{

			while (true)
			{
				try
				{

					ConsoleKeyInfo keyInfo = Console.ReadKey();
					char userInput1 = keyInfo.KeyChar;
					return (userInput1);
				}
				catch (FormatException ex)
				{
					Console.WriteLine("You enetered more than one number or letter." 
						+ "\n Please enter your input as a single number or letter: " + ex.Message);
				}
				catch (Exception ex)
				{
					Console.WriteLine("An error occurred: " + ex.Message);
				}


			}

		}


	}

	
}
