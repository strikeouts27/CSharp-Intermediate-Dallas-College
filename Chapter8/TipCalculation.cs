using System;
using static System.Console;
using System.Globalization;
class TipCalculation
{
	static void Main()
	{
		// Write your code here

		// Prompt The User 
		Console.WriteLine("Enter meal price:");
		string mealPriceInput = Console.ReadLine();
		double mealPrice;

		// mealprice is updated through the out variable. 
		if (!double.TryParse(mealPriceInput, out mealPrice))
		{
			Console.WriteLine("Invalid meal price. Please enter a valid number.");
			return; // or prompt again
		}

		Console.WriteLine("Enter tip percent (e.g., 0.20):");
		string tipPercentInput = Console.ReadLine();
		double tipPercent;

		if (!double.TryParse(tipPercentInput, out tipPercent))
		{
			Console.WriteLine("Invalid tip percent. Please enter a valid number.");
			return; // or prompt again
		}
		if (!double.TryParse(tipPercentInput, out tipPercent))
		{
			Console.WriteLine("Invalid tip percent. Please enter a valid number.");
			return;
		}
		if (tipPercent > 1)
		{
			tipPercent = tipPercent / 100;
		}

		
		double totalBill = 0;
		double tipAmount = BillCalculation(mealPrice, tipPercent, out totalBill);

		DisplayTipInfo(mealPrice, tipPercent, tipAmount, totalBill); 
	}

	public static void DisplayTipInfo(double mealPrice, double tipPercent, double tipAmount, double totalBill)
	{
		
		Console.WriteLine($"Meal price: {mealPrice:F2}. Tip percent: {tipPercent:F2}");
		Console.WriteLine($"Tip in dollars: {tipAmount:f2}. Total bill {totalBill:F2}");
				
	}

	public static double BillCalculation(double mealPrice, double tipPercent, out double totalBill)
	{
		double tipAmount = mealPrice * tipPercent;
		totalBill = mealPrice + tipAmount; 
		return tipAmount; 		
	}

	public static double BillCalculation(double mealPrice, int tipPercent, out double totalBill)
	{
		double tipAmount = mealPrice * tipPercent;
		totalBill = mealPrice + tipAmount;
		return tipAmount;
	}
}