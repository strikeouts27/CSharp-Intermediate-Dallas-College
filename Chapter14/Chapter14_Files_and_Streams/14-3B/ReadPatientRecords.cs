using System;
using System.IO;
using static System.Console;
using System.Globalization;

/* 
Instructions 
Using the output file generated from your program in Exercise 3A, write the program FindPatientRecords that prompts the user for an ID number, reads records from Patients.txt, and displays data for the specified record. If the record does not exist, display the following error message:
No records found for p#
An example of the program is shown below:
Enter patient ID number to find >> p1
ID Number Name                 Balance
p1        Patient1              $20.00
    In order to prepend the $ to currency values, the program will need to use the CultureInfo.GetCultureInfo method. In order to do this, include the statement using System.Globalization; at the top of your program and format the output statements as follows: WriteLine("This is an example: {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));


*/ 
class ReadPatientRecords
{
   static void Main()
   {
      const string fileName = "Patients.txt";
      const char delimiter = ',';

      if (!File.Exists(fileName))
      {
         WriteLine("File not found: {0}", fileName);
         return;
      }

      WriteLine("{0,-10}{1,-20}{2,12}", "IdNumber", "Name", "Balance");
      foreach (var line in File.ReadLines(fileName))
      {
         if (string.IsNullOrWhiteSpace(line))
            continue;

         var parts = line.Split(delimiter);
         if (parts.Length < 3)
            continue;

         var id = parts[0].Trim();
         var name = parts[1].Trim();
         double balance;
         if (!double.TryParse(parts[2].Trim(), out balance))
            continue;

         var balanceStr = balance.ToString("C", CultureInfo.GetCultureInfo("en-US"));
         WriteLine("{0,-10}{1,-20}{2,12}", id, name, balanceStr);
      }
   }
}
   

