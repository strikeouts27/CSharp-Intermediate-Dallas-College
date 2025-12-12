using System;
using static System.Console;
using System.Globalization;
using System.Linq;

class CountVowelsModularized
{
	public static void Main()
	{
		// Write your code here
		Console.WriteLine("Please enter in a word and we will determine how many vowels there are in that word!");
		string inputWord = Console.ReadLine();
		int numVowels = CountVowels(inputWord);
		Console.WriteLine($"You have {numVowels} vowels present in the word of {inputWord}");

	}

	public static int CountVowels(string inputWord)
	{
		string[] vowels = { "A", "E", "I", "O", "U" };
		int numVowels = 0;

		foreach (char i in inputWord.ToUpper())
		{
			// code block to be executed]
			if (vowels.Contains(i.ToString()))
			{

				numVowels++;

			}
			else if (!vowels.Contains(i.ToString()))
			{
				continue;

			}
			else
			{
				continue;

			}

		}
		return numVowels; 
	}
}