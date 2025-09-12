using System;

namespace FineForOverDueBooks
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter in the number of books that were checked out.");
            int numBooks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter in the number of days each book was overdue.");
            int numDaysOverDue = Convert.ToInt32(Console.ReadLine());
            double fine = DisplayFine(numBooks, numDaysOverDue);
            Console.WriteLine($"The fine for {numBooks} book(s) for {numDaysOverDue} day(s) is {fine:C}");
        }

        public static double DisplayFine(int numBooks, int numDaysOverDue)
        {
            double baseFine = 0.10;
            double punitiveFine = 0.20;
            double totalFine = 0;

            if (numDaysOverDue < 7)
            {
                totalFine = (baseFine * numDaysOverDue) * numBooks;
                return totalFine;
            }
            else if (numDaysOverDue > 7)
            {
                totalFine = ((baseFine * 7) * numBooks) + ((numDaysOverDue - 7) * punitiveFine) * numBooks;
                return totalFine;
            }
            else
            {
                Console.WriteLine("Error, invalid entry or logic error. Please input a valid number or contact the programmer for more information.");
                Environment.Exit(1); 
                double errorAmount =  0.01;
                return errorAmount; 
            }


        }
    }
}
