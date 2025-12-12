using System;
using System.Globalization;
using static System.Console;
using System.IO;

/* 

Create a program named WritePatientRecords that allows a doctor's staff to enter data about patients and saves the data to a file. The program should be structured as follows:

Patient Class: Implement a class named Patient with the following properties:

    IdNum: String property for the patient ID number.
    Name: String property for the patient's name.
    Balance: Double property for the current balance owed to the doctor's office.
    Include a ToString() method that formats these properties into a string for output.

Main Method:

    Implement a loop to continuously prompt for patient ID until 999 is entered, signifying the end of input.
    For each patient, prompt for and collect the name and balance. Convert the balance to double.
    After each entry, write the patient's data to Patients.txt using the format: IdNumber,Name,Balance.
    Utilize constants a comma (,) for delimiter in the output file, and 999 to signal input termination.

Example output

Enter patient ID number or 999 to quit >> p1
Enter last name >> Patient1
Enter balance >> 20
Enter next patient ID number or 999 to quit >> p2
Enter last name >> Patient2
Enter balance >> 40
Enter next patient ID number or 999 to quit >> p3
Enter last name >> Patient3
Enter balance >> 120
Enter next patient ID number or 999 to quit >> p4
Enter last name >> Patient4
Enter balance >> 20
Enter next patient ID number or 999 to quit >> p5
Enter last name >> Patient5
Enter balance >> 35
Enter next patient ID number or 999 to quit >> 999

    In order to prepend the $ to currency values, the program will need to use the CultureInfo.GetCultureInfo method. In order to do this, include the statement using System.Globalization; at the top of your program and format the output statements as follows: WriteLine("This is an example: {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));


*/ 
class Patient
{
   public string IdNum { get; set; }
   public string Name { get; set; }
   public double Balance { get; set; }

   public override string ToString()
   {
      return string.Join(",", new[] { IdNum ?? string.Empty, Name ?? string.Empty, Balance.ToString() });
   }
}

class WritePatientRecords
{
   private const string Delimiter = ",";
   private const string QuitCode = "999";
   private const string OutputFileName = "Patients.txt";

   static void Main()
   {
      WriteLine("Enter patient ID number or {0} to quit >> ", QuitCode);

      using (var writer = new StreamWriter(OutputFileName, append: true))
      {
         while (true)
         {
            string idInput = ReadLine();
            if (idInput == null)
            {
               break;
            }

            idInput = idInput.Trim();
            if (string.Equals(idInput, QuitCode, StringComparison.OrdinalIgnoreCase))
            {
               break;
            }

            Write("Enter last name >> ");
            string nameInput = ReadLine() ?? string.Empty;
            nameInput = nameInput.Trim();

            double balance;
            while (true)
            {
               Write("Enter balance >> ");
               var balInput = ReadLine();
               if (double.TryParse((balInput ?? string.Empty).Trim(), out balance))
               {
                  break;
               }
               WriteLine("Invalid amount. Please enter a numeric balance.");
            }

            var patient = new Patient
            {
               IdNum = idInput,
               Name = nameInput,
               Balance = balance
            };

            writer.WriteLine(string.Join(Delimiter, new[] { patient.IdNum, patient.Name, patient.Balance.ToString() }));
            writer.Flush();

            WriteLine(
               "Saved: {0}, {1}, {2}",
               patient.IdNum,
               patient.Name,
               patient.Balance.ToString("C", CultureInfo.GetCultureInfo("en-US"))
            );

            Write("Enter next patient ID number or {0} to quit >> ", QuitCode);
         }
      }
   }
}
