using System;
namespace DemoGeneric
{
    public class GenericOperation
    {
         public void ToPrintArray(int[] intArr)
         {
             foreach (var data in intArr)
             {
                 Console.WriteLine(data);
             }
         }

         public void ToPrintArray(double [] doubleArr) // we initialise intArr we can also use doubleArr or anything
         {
             foreach (var data in doubleArr)
             {
                 Console.WriteLine(data);
             }
         }

         public void ToPrintArray(char[] charArr)
         {
             foreach (var data in charArr)
             {
                 Console.WriteLine(data);
             }
         } 
    }
}
