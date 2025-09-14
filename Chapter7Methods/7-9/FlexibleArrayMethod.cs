using System;
using static System.Console;
using System.Globalization;
class FlexibleArrayMethod
	{
	static void Main()
	{
		// Write your code here
		{
			int[] oneArray = { 1 };
			int[] twoArray = { 1, 2 };
			int[] threeArray = { 1, 2, 3 };

			DisplayAndSum(oneArray);
			DisplayAndSum(twoArray);
			DisplayAndSum(threeArray);
		}
	}

	public static int DisplayAndSum(int[] array)
		{
			int arraySum = 0;
		for (int i = 0; i < array.Length; ++i)
		{
			arraySum += array[i];
			Console.WriteLine($"Now adding {array[i]}");
				
		}
		Console.WriteLine($"The total sum is {arraySum}"); 
			return arraySum;
		}
	}