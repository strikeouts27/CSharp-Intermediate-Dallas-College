using System;
using static System.Console;
using System.Globalization;
class StudentGradeDemo
{
	static void Main()
	{

		// Write your code here
        /* 
        Write the program StudentGradeDemo that attempts to create several valid and invalid ReportCard objects. Immediately after each instantiation attempt, handle any thrown exceptions by displaying an error message.
        Create a ReportCard class with four fields for a student name, a numeric midterm grade, a numeric final exam grade, and letter grade. The ReportCard constructor requires values for the name (string) and two numeric grades (midterm and final as int) and determines the letter grade. Upon construction, throw an ArgumentException` if the midterm or final exam grade is less than 0 or more than 100.
        The letter grade is based on the arithmetic average of the midterm and final exams using a grading scale of A for an average of 90 to 100, B for 80 to 90, C for 70 to 80, D for 60 to 70, and F for an average below 60. Display all the data if the instantiation is successful.
        */ 
        string grade = (""); 
        System.Console.WriteLine("Please enter the midterm grade.");
        // int.Parse when you know for a fact that you want a specific data type. 
        int Test = 0; 
        string Temp = Console.ReadLine(); 
        while (int.TryParse(Temp, out Test) == false)
        {
            System.Console.WriteLine("Please enter the midterm grade.");
            // int.Parse when you know for a fact that you want a specific data type. 
            
            Temp = Console.ReadLine();
        }
        int midterm = int.Parse(Temp); 
        System.Console.WriteLine("Please enter the final grade.");
        
        // int.Parse when you know for a fact that you want a specific data type. 
       
        Temp = Console.ReadLine(); 
        while (int.TryParse(Temp, out Test) == false)
        {
            System.Console.WriteLine("Please enter the final grade.");
            // int.Parse when you know for a fact that you want a specific data type. 
            
            Temp = Console.ReadLine();
        }
        int final = int.Parse(Temp);

        ReportCard failCase = new ReportCard("Andrew", midterm, final, grade);
        System.Console.WriteLine(failCase.ToString());

	}

   
}

public class ReportCard
{
    // fields 
    private string name; 
    private int midtermGrade; 
    private int finalExamGrade; 
    private string grade; 
    
    // constructor code 
    public ReportCard(string name, int midtermGrade, int finalExamGrade, string grade)
    {
        if(midtermGrade < 0 || midtermGrade > 100) 
        {
            throw new ArgumentException();
        }
        if(finalExamGrade < 0 || finalExamGrade > 100)
        {
            throw new ArgumentException(); 
        }
        // grab the parameter value and pass it to the field inside the class.
        this.name = name; 
        this.midtermGrade = midtermGrade; 
        this.finalExamGrade = finalExamGrade; 
        this.grade = grade; 
        calculateLetterGrade();
    }
    public void calculateLetterGrade()
    {
        int avg = (midtermGrade + finalExamGrade)/2; 
        if(avg >= 90 && avg <= 100)
        {
            grade = "A"; 
        }
        else if (avg >= 80 && avg <= 89)
        {
            grade = "B"; 
        }
        else if (avg >= 70 && avg <= 79)
        {
            grade = "C"; 
        }
        else if (avg >= 60 && avg <= 69)
        {
            grade = "D"; 
        }
        else if (avg < 60)
        {
            grade = "F";
        }
    }
    public string ToString()
    {
        return string.Format($"The calculated grade is {grade}");
    }
}