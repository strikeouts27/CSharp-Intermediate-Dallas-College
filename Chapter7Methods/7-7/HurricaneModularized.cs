using System;
using static System.Console;
using System.Globalization;
class HurricaneModularized
{
	static void Main(string[] args)
	{
		// Write your code here
		Console.WriteLine("Please enter in the mph of the hurricane and we will tell you that category of hurricane it would fall into. The category of this hurricane based on the windspeed is Invalid input. Please input whole numbers.");
		int windSpeed = Convert.ToInt32(Console.ReadLine());
		string category = EvaluateHurricane(windSpeed);
		Console.WriteLine($"The category of this hurricane based on the windspeed is {category}");

	}

	public static string EvaluateHurricane(int windSpeed)
	{
		if (windSpeed < 74)
		{
			return "Not a hurricane";
		}
		else if (windSpeed >= 74 && windSpeed <= 95)
		{
			return "1";
		}
		else if (windSpeed >= 96 && windSpeed <= 110)
		{
			return "2";
		}
		else if (windSpeed >= 111 && windSpeed <= 129)
		{
			return "3";
		}
		else if (windSpeed >= 130 && windSpeed <= 156)
		{
			return "4";
		}
		else if (windSpeed >= 157)
		{
			return "5";
		}
		return "Invalid input"; // This line is valid and should remain
	}
}