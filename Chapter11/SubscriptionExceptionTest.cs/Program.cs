using System;
using static System.Console;
using System.Globalization;
class FindSquareRoot
{
	static void Main()
	{
		// Write your code here

		// create a way for the user to make data entry 
		while (true)
        {
			System.Console.WriteLine("Enter a number ");
            string str = Console.ReadLine();
			double value = -1; 


			bool result = double.TryParse(str, out value); 
			if (result == true)
            {

				double number = double.Parse(str); 
				double sqNum = Math.Sqrt(number); 
				if (number < 0)
                {
					sqNum = 0; 
                    try
                    {
                        throw new ApplicationException("Error: Number can't be negative."); 
					}
					catch(Exception e)
                    {
                       System.Console.WriteLine(e.Message); 
                    }
                }
				System.Console.WriteLine($"Square root is {sqNum}");
				
            }
			else if (result == false)
            {
				double sqNum = 0; 
				System.Console.WriteLine("value was not appropriate");
				// every exception is a method that requires a parenthesis we have the option to pass in a message.
                // throw new ApplicationException("Error: Number can't be negative."); 
            }
			

			// 
        }
		// I need to convert the users request to an int
		 
		

		// display an appropriat emessage 
		// set the square root value to 0. 

		// else condition test the input numbers value for it to be negative. 
		// if thats the case throw the new ApplicationException and message "Number cannot be negative." 
		// again set the sqare root to 0. 

		// if the input value is a double and not negative, pass it to the math.sqrt() method and display the returned value. 
	}
}