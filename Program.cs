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

            

            Helpers.Print("Press any key to close..");

            Helpers.GetStrInput();
        }

        


        
      
    }
}
