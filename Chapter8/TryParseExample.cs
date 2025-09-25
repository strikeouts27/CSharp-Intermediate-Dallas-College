public static int FillArray(int[] integerArray)
{
    int count = 0;
    for (int i = 0; i < integerArray.Length; i++)
    {
        Console.Write("Enter an integer (or 999 to stop): ");
        string input = Console.ReadLine();
        int value;
        if (int.TryParse(input, out value))
        {
            if (value == 999)
                break;
            integerArray[i] = value;
            count++;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
            i--; // repeat this iteration
        }
    }
    return count;
}