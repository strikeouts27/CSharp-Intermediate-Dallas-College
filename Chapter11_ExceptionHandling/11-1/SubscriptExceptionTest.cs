using System;
using static System.Console;
using System.Globalization;
class SubscriptExceptionTest
{
	static void Main()
	{
		// Write your code here
		double[] myArray = new double[10]{1,2,3,4,5,6,7,8,9,10};

		ProcessArray(myArray);
	}

	public static void ProcessArray(double[] myArray)
	{
		Console.WriteLine("Enter an array subscript (0-9) to view the value.");
		Console.WriteLine("Enter 99 to quit.");

		while (true)
        {
			string? input = Console.ReadLine();
			if (input == "99")
            {
				break;
            }

			try
            {
				if (!int.TryParse(input, out int index))
                {
					throw new FormatException();
                }

				if (index < 0 || index >= myArray.Length)
                {
					throw new IndexOutOfRangeException("Index was outside the bounds of the array");
                }

				Console.WriteLine(myArray[index]);
            }
			catch (IndexOutOfRangeException ex)
            {
				Console.WriteLine(ex.Message);
            }
			catch (FormatException)
            {
				Console.WriteLine("Format Exception caught.");
            }
        }
	}
		/*
		
		- THIS PROCES MUST CONTINUE UNTIL COMPLETE. 
		- THE INSTRUCTIONS SAY THE USER CAN ENTER 99 TO LEAVE THE CODE IF THEY WISH.
		- THIS PROCESS MUST HANDLE INVALID INPUTS WITH A TRY BLOCK LOGIC. 
		-  
		*/

		/* 
		AFTER THE ARRAY IS COMPLETE 
		*/


	}