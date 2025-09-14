using System;
using static System.Console;
using System.Globalization;
class SalesLetter
{
	static void Main()
	{
		// Write your code here
		Console.WriteLine("From: ");
		DisplayContactInfo();
		Console.WriteLine("Dear Client, /n");
		Console.WriteLine("We want to provide you good service. /n");
		Console.WriteLine("Feel free to contact us at any time.");
		DisplayContactInfo();
		Console.WriteLine("Looking forward to a long relationship. ");
		DisplayContactInfo(); 
		
		// should contain at least three lines with data such as land line 
		// phone number and/or cellphone number, email address, and web address.

		
	}

	static void DisplayContactInfo()
	{
		string landLinePhone = "555-555-1234"; 
		string cellPhone = "222-222-2222";
		string companyName = "C# Company";
		string email = "csharpcompany@csharp.com";
		string website = "www.csharpcompanyforyou.com";

		WriteLine(companyName); 
		WriteLine($"Phone: {landLinePhone}     {cellPhone}"); 
		WriteLine($"Email: {email}"); 
		WriteLine($"On the Web at {website}");
	}
}