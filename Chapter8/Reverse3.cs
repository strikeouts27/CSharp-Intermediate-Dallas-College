using System;
using static System.Console;

class Reverse3
{
    static void Main()
    {
        int firstInt = 23;  // Example values
        int middleInt = 45;
        int lastInt = 67;

        WriteLine($"Original numbers: {firstInt}, {middleInt}, {lastInt}");
        Reverse(ref firstInt, ref middleInt, ref lastInt);
        WriteLine($"Reversed numbers: {firstInt}, {middleInt}, {lastInt}");
    }

    static void Reverse(ref int firstInt, ref int middleInt, ref int lastInt)
    {
        // Swap first and last using tuple deconstruction
        (firstInt, lastInt) = (lastInt, firstInt);
        // Middle remains unchanged

        
    }
}