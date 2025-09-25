using System;
using static System.Console;
using System.Globalization;
using System.Linq; 

class IntegerFacts
{
    static void Main()
    {
        // 1. Write your code here

        // 2. Create a program named IntegerFacts whose Main() method declares an array of ten integers. - COMPLETED 

        // 3. Call a method named FillArray to interactively fill the int[] array  = new int[10];array with any number of values up to ten or until a sentinel value (999) is entered.
        int[] array = new int[10];
        int count = FillArray(array); // array is filled inside FillArray

        // 4.  Create and Call Statistics Method that accepts out parameters for the highest value in the array, lowest value in the array, sum of the values in the array, and arithmetic average.
        int values = array.Length;
        int max;
        int min;
        int sum;
        double avg;

        // 5. In the Main() method, display all the statistics in the following format:
        Statistics(array, values, out max, out min, out sum, out avg); 

        Console.WriteLine("The array has {0} values", values);
        Console.WriteLine("The highest value is {0}", max);
        Console.WriteLine("The lowest value is {0}", min);
        Console.WriteLine("The sum of the values is {0}", sum);
        Console.WriteLine("The average is {0}", avg); 
    }

    // when you pass in an array to a method, it updates the array where it is declared as well. 
    // arrays are reference types. // so there is no need to return the array. 
    public static int FillArray(int[] array)
    {

        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Enter in 10 integers to fill the array.");
            string input = Console.ReadLine();
            int value;
            if (int.TryParse(input, out value))
            {
                if (value == 999)
                    break;
                array[i] = value;
                count++;
            }
            else
            {
                Console.WriteLine("Invalid.");
                i--; // repeat this iteration
            }
        }
        return count;
    }

    public static void Statistics(int[] array, int value, out int max, out int min, out int sum, out double avg)
    {
        max = array.Max();
        min = array.Min();
        sum = array.Sum();
        avg = array.Average();
    }
}