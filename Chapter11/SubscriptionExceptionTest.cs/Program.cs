class SubscriptExceptionTest
{
    static void Main()
    {
        double[] myArray = new double[10]{1,2,3,4,5,6,7,8,9,10};
        ProcessArray(myArray);
    }

    public static void ProcessArray(double[] myArray)
    {
        Console.WriteLine("Enter an array subscript (0-9) to view the value.");
        Console.WriteLine("Enter 99 to quit.");

        while (true)
        {
            string? input = Console.ReadLine();
            if (input == "99")
            {
                break;
            }

            try
            {
                if (!int.TryParse(input, out int index))
                {
                    throw new FormatException();
                }

                Console.WriteLine(myArray[index]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index was outside the bounds of the array");
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception caught.");
            }
        }
    }
}