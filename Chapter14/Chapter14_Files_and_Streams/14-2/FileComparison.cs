using System;
using System.IO;

class FileComparison
{
    static void Main()
    /* 
    Write the program FileComparison that compares two files. 
    Two files have been provided for you, Quote.txt and Quote.docx.

    Next write the file comparison application that displays the sizes of the two files as well as the ratio of their sizes to each other. To discover a file’s size, you can create a System.IO.FileInfo object using statements such as the following, where FILE_NAME is a string that contains the name of the file, and size has been declared as an integer:

      FileInfo fileInfo = new FileInfo(FILE_NAME);
      size = fileInfo.Length;

        Your program's output should look like the following:

        The size of the Word file is FILE_SIZE
        and the size of the Notepad file is FILE_SIZE
        The Notepad file is x% of the size of the Word file

    */ 
    {
        // Define the file names
        string file1 = "Quote.txt";
        string file2 = "Quote.docx";

        // Create FileInfo objects for both files
        FileInfo info1 = new FileInfo(file1);
        FileInfo info2 = new FileInfo(file2);

        // Get the file sizes
        long size1 = info1.Length;
        long size2 = info2.Length;

        // Display the file sizes
        Console.WriteLine($"{file1} size: {size1} bytes");
        Console.WriteLine($"{file2} size: {size2} bytes");
        Console.WriteLine();

        // Calculate and display the ratio of file sizes
        if (size1 > 0 && size2 > 0)
        {
            double ratio = (double)size1 / size2;
            Console.WriteLine($"Ratio of {file1} to {file2}: {ratio:F2}");

            // Display which file is larger
            if (size1 > size2)
            {
                Console.WriteLine($"{file1} is {size1 - size2} bytes larger than {file2}");
            }
            else if (size2 > size1)
            {
                Console.WriteLine($"{file2} is {size2 - size1} bytes larger than {file1}");
            }
            else
            {
                Console.WriteLine("Both files are the same size");
            }
        }
        else
        {
            Console.WriteLine("One or both files are empty or do not exist");
        }
    }
}
