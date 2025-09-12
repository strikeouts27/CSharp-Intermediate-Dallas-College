using static System.Console;
class CompareNames1
{
   static void Main()
   {
      string name1 = "Amy";
      string name2 = "Amy";
      string name3 = "Matthew";
      WriteLine("compare {0} to {1}: {2}",
         name1, name2, name1 == name2);
      WriteLine("compare {0} to {1}: {2}",
         name1, name3, name1 == name3);
   }
}
