using System;
using static System.Console;
using System.Globalization;
class Reverse4
{
    static void Main()
    {
        int firstInt = 23;
        int secondInt = 45;
        int thirdInt = 55;
        int fourthInt = 67;
        Console.WriteLine($"The numbers are {firstInt} {secondInt} {thirdInt} {fourthInt}");
        UpdateReverse(ref firstInt, ref secondInt, ref thirdInt, ref fourthInt);
        Console.WriteLine($"The numbers are {firstInt} {secondInt} {thirdInt} {fourthInt}");
    }

    public static void UpdateReverse(ref int firstInt, ref int secondInt, ref int thirdInt, ref int fourthInt)
    {
        int temp1 = firstInt;
        int temp2 = secondInt;
        int temp3 = thirdInt;
        int temp4 = fourthInt;

        firstInt = temp4;
        secondInt = temp3;
        thirdInt = temp2;
        fourthInt = temp1;
    }
}
