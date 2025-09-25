using System;
using static System.Console;
using System.Globalization;
class Auction
{
    static void Main()
    {
        const int MIN = 10;

        Console.WriteLine("Please enter your bid >>");
        string input = Console.ReadLine();

        // 1. Correct TryParse usage and variable names
        if (int.TryParse(input, out int intAmount))
        {
            AcceptBid(intAmount, MIN);
        }
        // 2. Correct TryParse usage and variable names
        else if (double.TryParse(input, out double doubleAmount))
        {
            AcceptBid(doubleAmount, MIN); // Changed from outAmount to doubleAmount
        }
        // 3. Corrected Substring source and removed semicolon
        else if (input.StartsWith("$") && int.TryParse(input.Substring(1), out int dollarSignIntAmount))
        {
            AcceptBid(dollarSignIntAmount, MIN); // Changed from dollarSignAmount to dollarSignIntAmount
        }
        // 4. Corrected variable name and scope
        else if (input.EndsWith("dollars"))
        {
            string numberPart = input.Substring(0, input.Length - "dollars".Length).Trim();
            if (int.TryParse(numberPart, out int amount))
            {
                AcceptBid(amount, MIN); // Changed from input, min to amount, MIN
            }
        }
        else
        {
            Console.WriteLine("Bid was not in a valid format");
        }
        // 5. Ensured all methods are inside the class (moved misplaced closing brace)
    }

    public static void AcceptBid(int bid, int min)
    {
        if (bid > min)
            Console.WriteLine("Bid accepted.");
        else if (bid < min)
            Console.WriteLine("Bid not high enough");
        else
            Console.WriteLine("Bid was not in correct format");
    }

    public static void AcceptBid(double bid, int min)
    {
        if (bid > min)
            Console.WriteLine("Bid accepted.");
        else if (bid < min)
            Console.WriteLine("Bid not high enough");
        else
            Console.WriteLine("Bid was not in correct format");
    }

    public static void AcceptBid(string bid, int min)
    {
        // Check if bid starts with '$' and the rest is numeric
        if (bid.StartsWith("$") && int.TryParse(bid.Substring(1), out int dollarAmount))
        {
            if (dollarAmount >= min)
                Console.WriteLine("Bid accepted.");
            else
                Console.WriteLine("Bid not high enough");
        }
        // Check if bid ends with 'dollars' and the preceding part is numeric
        else if (bid.EndsWith("dollars"))
        {
            string numberPart = bid.Substring(0, bid.Length - "dollars".Length).Trim();
            if (int.TryParse(numberPart, out int amount))
            {
                if (amount >= min)
                    Console.WriteLine("Bid accepted.");
                else
                    Console.WriteLine("Bid not high enough");
            }
            else
            {
                Console.WriteLine("Bid was not in correct format");
            }
        }
        else
        {
            // Try to parse as double for cases like "12.50"
            string cleaned = bid.Replace("$", "").Replace("dollars", "").Trim();
            if (double.TryParse(cleaned, out double bidValue))
            {
                AcceptBid(bidValue, min);
            }
            else
            {
                Console.WriteLine("Bid was not in correct format");
            }
        }
    }
}