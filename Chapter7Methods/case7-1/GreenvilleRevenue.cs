using System;
using static System.Console;
using System.Globalization;
class GreenvilleRevenue
{
   public static void Main()
   {
      int lastYearNumberOfContestants = 0;
      int currentYearNumberOfContestants = 0;

      int activeContestants = 0;
      int singingContestants = 0;
      int dancingContestants = 0;
      int musicalContestant = 0;
      int otherContestant = 0;

      GetContestantNumber(ref lastYearNumberOfContestants, ref currentYearNumberOfContestants);
      DisplayRelationship(lastYearNumberOfContestants, currentYearNumberOfContestants);
      GetLists(ref activeContestants, ref singingContestants, ref dancingContestants, ref musicalContestant, ref otherContestant);
      GetContestantData(activeContestants, singingContestants, dancingContestants, musicalContestant, otherContestant);

   }
   public static int GetContestantNumber(ref int lastYearNumberOfContestants, ref int currentYearNumberOfContestants)
   {
      Console.WriteLine("Enter number of contestants last year >>");
      string lastYearInput = Console.ReadLine();
      int.TryParse(lastYearInput, out lastYearNumberOfContestants);

      Console.WriteLine("Enter number of contestants this year >>");
      string currentYearInput = Console.ReadLine();
      int.TryParse(currentYearInput, out currentYearNumberOfContestants);

      return currentYearNumberOfContestants; 
   }

   public static void DisplayRelationship(int lastYearNumberOfContestants, int currentYearNumberOfContestants)
   {
      double revenue = currentYearNumberOfContestants * 25.00;
      Console.WriteLine("Last year's competition had {0} contestants, and this year's has {1} contestants", lastYearNumberOfContestants, currentYearNumberOfContestants);

      if (lastYearNumberOfContestants > currentYearNumberOfContestants)
      {
         Console.WriteLine("We will have fewer contestants than last year, if you are still interested contact us and we will give you a chance to enter!");
      }
      else if (currentYearNumberOfContestants > (lastYearNumberOfContestants * 2))
      {
         Console.WriteLine("This contest is bigger than ever!");
      }
      else if (currentYearNumberOfContestants > lastYearNumberOfContestants)
      {
         Console.WriteLine("The competition is bigger but not twice as big as last year!");
      }
      else
      {
         Console.WriteLine("Error, please input a valid number for the contestants that participated last year and this year!");
      }

   }

   public static void GetLists(ref int activeContestants, ref int singingContestants, ref int dancingContestants, ref int musicalContestant, ref int otherContestant)
   {
      string addAnother = "Y";
      while (addAnother == "Y")
      {
         Console.WriteLine("Enter the contestant name >>");
         string contestantName = Console.ReadLine();
         Console.WriteLine("Talent codes are: \n S   Singing\n D   Dancing\n M   Musical instrument \n O   Other\n Enter talent code >>");
         string input = Console.ReadLine().ToUpper();

         if (input == "S")
         {
            activeContestants++;
            singingContestants++;

         }
         else if (input == "D")
         {
            activeContestants++;
            dancingContestants++;
         }
         else if (input == "M")
         {
            activeContestants++;
            musicalContestant++;
         }
         else if (input == "O")
         {
            activeContestants++;
            otherContestant++;
         }
         else
         {
            Console.WriteLine("Invalid entry please try again!");
         }
         Console.WriteLine("Do you want to add another contestant? If type (Y/N)");
         addAnother = Console.ReadLine().ToUpper();
         if (addAnother == "Y")
         {
            continue; 
         }
         else if (addAnother == "N")
         {
            break;
         }
         else
         {
            Console.WriteLine("Invalid entry. Please type Y or N!");
         }

      }
   }

   public static void GetContestantData(int activeContestants, int singingContestants, int dancingContestants, int musicalContestant, int otherContestant) 
   {
      Console.WriteLine("\nThe types of talent are:");
      Console.WriteLine($"Singing                   {singingContestants}");
      Console.WriteLine($"Dancing                   {dancingContestants}");
      Console.WriteLine($"Musical instrument        {musicalContestant}");
      Console.WriteLine($"Other                     {otherContestant}");
   }
}

