using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasics_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Multiplication.ShowTable();

            //GuessingGame.GuessTheNumber();

            /* Arrays and Lists */
            int[] numbers = { 1, 900, 50, 1000, 55 };

            //Collections.GetLargestElement(numbers);

            //Collections.ReverseAnArray(numbers);

            string[] pets = { "Dog", "Cat", "Fish", "Rabbit"};

            //Collections.CheckOccurenceOfElement(pets, "Dog");

            //Collections.ReturnOddElements(pets);

            double[] salesPerDays = { 1250.15, 3096.50, 510.50, 4000, 1000 };

            //Collections.GetTotalSales(salesPerDays);

            //Looping.GetSumViaForLoop(salesPerDays);

            //Looping.GetSumViaWhileLoop(salesPerDays);

            //double sum = Looping.GetSumViaRecursively(salesPerDays, 0, 0);
            //Helpers.PrintLn("Total Sales is: " + sum.ToString());

            /* Concat List */
            List<string> list1 = new List<string> { "a", "b", "c" };
            List<string> list2 = new List<string> { "1", "2", "3"};
            Collections.ConcatLists(list1, list2);

            Collections.AlternateCombine(list1, list2);

            Helpers.Print("Press any key to close..");

            Helpers.GetStrInput();
        }

        


        
      
    }
}
