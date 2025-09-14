using System;
using static System.Console;
using System.Globalization;
class AdmissionModularized
{
	static void Main()
	{
		// Write your code here

		Console.WriteLine("Please enter in your applicants GPA.");
		double GPA = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Please enter in your applicants Test Score.");
		int TestScore = Convert.ToInt32(Console.ReadLine());

		string outcome = AcceptOrReject(GPA, TestScore);
		Console.WriteLine(outcome);
	}

	static string AcceptOrReject(double GPA, int TestScore)
	{
		if (GPA > 3.0 && TestScore >= 60)
		{
			return "Accept";
		}
		else if (GPA <= 3.0 && TestScore >= 80)
		{
			return "Accept";
		}
		else
		{
			return "Reject";
		}
	}
	
}