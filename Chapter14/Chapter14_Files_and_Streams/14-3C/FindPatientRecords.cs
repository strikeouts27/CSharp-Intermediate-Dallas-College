using System;
using static System.Console;
using System.Globalization;
using System.IO;
class FindPatientRecords
{
   static void Main()
   {
      const string FILENAME = "Patients.txt";
      const string DELIM = ",";
      bool found = false;
      
      Write("Enter patient ID number to find >> ");
      string searchId = ReadLine();
      
      if(!File.Exists(FILENAME))
      {
         WriteLine("Error: " + FILENAME + " does not exist.");
         return;
      }
      
      try
      {
         using(StreamReader reader = new StreamReader(FILENAME))
         {
            string line;
            while((line = reader.ReadLine()) != null)
            {
               string[] fields = line.Split(DELIM);
               if(fields.Length >= 3)
               {
                  string patientId = "p" + fields[0];
                  string patientName = fields[1];
                  double balance = Convert.ToDouble(fields[2]);
                  
                  if(patientId.Equals(searchId, StringComparison.OrdinalIgnoreCase))
                  {
                     found = true;
                     WriteLine("\nID Number Name                 Balance");
                     WriteLine();
                     WriteLine("{0,-10}{1,-21}{2}", 
                        patientId, 
                        patientName, 
                        balance.ToString("C", CultureInfo.GetCultureInfo("en-US")));
                     break;
                  }
               }
            }
         }
         
         if(!found)
         {
            WriteLine("\nNo records found for " + searchId);
         }
      }
      catch(Exception ex)
      {
         WriteLine("Error reading file: " + ex.Message);
      }
   }
}
   
