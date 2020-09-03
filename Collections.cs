using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasics_1
{
    class Collections
    {
        public static void GetLargestElement(int[] numberArray)
        {
            DefinedIntArrayMsg(numberArray);

            Helpers.PrintLn("The max number is:" + numberArray.Max().ToString());
        }

        public static void ReverseAnArray(int[] numberArray)
        {
            DefinedIntArrayMsg(numberArray);

            Helpers.PrintLn("The reversed of array is:");

            Array.Reverse(numberArray);

            
            Helpers.PrintIntArr(numberArray);
        }

        static void DefinedIntArrayMsg(int[] numberArray)
        {
            Helpers.PrintLn("Defined array is:");

            Helpers.PrintIntArr(numberArray);
        }

        static void DefinedStrArrayMsg(string[] strArray)
        {
            Helpers.PrintLn("Defined array is:");
            Helpers.PrintStringArr(strArray);
        }

        public static void CheckOccurenceOfElement(string[] strArray, string keyword)
        {
            DefinedStrArrayMsg(strArray);

            if (!strArray.Contains(keyword))
            {
                Helpers.PrintLn("Uh No Occurence of " + keyword);
            } else
            {
                Helpers.PrintLn(keyword + " is on the list");
            }
           
        }

        public static void ReturnOddElements(string[] strArray)
        {
            for (int i = 0; i < strArray.Length; i = i + 2)
            {
                Helpers.PrintLn($"{strArray[i]}");
            }
        }

        public static void GetTotalSales(double[] numberArray)
        {
            Helpers.PrintLn("Total Sales is: " + numberArray.Sum().ToString());
        }



    }
}
