using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasics_1
{
    class Looping
    {
        public static void GetSumViaForLoop(double[] sales)
        {
            double sum = 0;

            for (int i = 0; i < sales.Length; i++)
            {
                sum += sales[i];
            }

            Helpers.PrintLn("Total Sales is: " + sum.ToString());

        }

        public static void GetSumViaWhileLoop(double[] sales)
        {
            double sum = 0;

            int i = 0;

            while (i < sales.Length)
            {
                sum += sales[i];
                i++;
            }

            Helpers.PrintLn("Total Sales is: " + sum.ToString());

        }

        public static double GetSumViaRecursively(double[] sales, int i, double sum)
        {
           return (i >= sales.Length) ? sum :
           GetSumViaRecursively(sales, i + 1, sales[i] + sum );
        }

       

    }
}
