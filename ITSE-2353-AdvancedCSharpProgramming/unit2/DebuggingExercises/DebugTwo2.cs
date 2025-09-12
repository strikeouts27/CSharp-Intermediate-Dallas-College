// This program greets the user
// and multiplies two entered values
using System;
using static System.Console;
class DebugTwo2
{
   static void main()
   {
      string name;
      string firstString, secondSting;
      int first, second, product;
      Write("Enter your name >> );
      name = ReadLine;
      Write("Hello, {0}! Enter an integer >> ", name);
      firstString = ReadLine();
      first = ConvertToInt32(firstString);
      Write("Enter another integer >> ");
      secondString = Readline();
      second = Convert.ToInt(secondString);
      product = first * second;
      WriteLine("Thank you, {1}. The product of {2} and {3} is {4}",
	 name, first, second, product);
   }
}
