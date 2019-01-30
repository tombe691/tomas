using System;

public class Example
{
   public static void Main()
   {
      int caseSwitch = 1;
      
      switch (caseSwitch)
      {
          case 1:
          
            int test = 1;
              Console.WriteLine("Case 1");
              break;
          
          case 2:
          
            int test2 = 2;
              Console.WriteLine("Case 2");
              break;
          
          default:
            Console.WriteLine(test);
              Console.WriteLine("Default case");
              break;
      }
   }
}
// The example displays the following output:
//       Case 1