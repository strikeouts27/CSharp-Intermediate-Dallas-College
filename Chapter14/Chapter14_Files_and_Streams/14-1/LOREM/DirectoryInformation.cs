using System;
using static System.Console;
using System.IO;



class DirectoryInformation
{
   static void Main()
   {
      // Write your code here
/* 
Write the program named DirectoryInformation that allows a user to continually enter directory names until the user types end. 
If the directory name exists, display a list of the files in it; otherwise, display the following message, Directory foo does not exist, to indicate the directory does not exist (foo would be the name of the directory to be checked) . Create as many test directories and files as necessary to test your program.
An example of the program is shown below:
Enter a directory >> lorem
lorem contains the following files
  lorem/ipsum.txt
Enter another directory or type end to quit >> foo
Directory foo does not exist
*/ 
      // while loop '
      string END = "END";
      string directory; 
      string[] listOfFiles; 
      char DELIM = '\\';
      string dir = "";
    // for loop has grabbed the text files
    // now i need to spit out what is inside and than format it. 

    // arrays cannot be printed out to see values. 
    // we can access array values at indexes using bracket notation [i]


      System.Console.WriteLine("Enter a directory.");
      string directoryName = Console.ReadLine().ToUpper();
      while(directoryName != END)
        {
            if(Directory.Exists(directoryName))
            {
                listOfFiles = Directory.GetFiles(directoryName);
                
                if(Directory.Exists(directoryName)== false)
                {
                    System.Console.WriteLine("This pulled a null value.");
                    listOfFiles = Directory.GetDirectories(directoryName);
                }
                for(int i = 0; i < listOfFiles.Length; i++)
                {
                    string[] splitArray = listOfFiles[i].Split(DELIM); 
                    
                    for (int j = 0; j < splitArray.Length; j++)
                    {
                      // WriteLine(splitArray[j]);
                      if (j < splitArray.Length - 1)
                        {
                            dir += splitArray[j] + "/";
                        }   
                      else
                        {
                            dir += splitArray[j];
                        }
                    }
                    WriteLine($"{directoryName} contains the following files \n {dir}");
                    dir = ""; 
                    System.Console.WriteLine("Enter another directory or type end to quit");
                    directoryName = System.Console.ReadLine().ToUpper();  
                
                }
            }
            else 
            {
                System.Console.WriteLine($"Directory {directoryName} does not exist.");
                // directoryName = Console.ReadLine().ToUpper();
            }
            System.Console.WriteLine("Enter a directory. Or type end to quit.");
            directoryName = Console.ReadLine().ToUpper();
        }
   }
}