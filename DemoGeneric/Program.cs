using System;
namespace DemoGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = { 1, 2, 3, 4, 5, 6, 7 };
            double[] doubleArr = { 1.02, 2.03000, 3.05, 4.022 };
            char[] charArr = { 'a', 'b', 'c', 'd', 'e', };
            GenericOperation genericOperation = new GenericOperation();
            genericOperation.ToPrintArray(intArr);
            genericOperation.ToPrintArray(doubleArr);
            genericOperation.ToPrintArray(charArr);
        }
    }
}