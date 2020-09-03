using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasics_1
{
    class Multiplication
    {
        static int limit = 12;

        public static void ShowTable()
        {
           
            for (int i = 1; i <= limit; i++)
            {
                MultiplicationResult(i);

            }
        }

        public static void MultiplicationResult(int counter)
        {
            for (int j = 1; j <= limit; j++)
            {
                int result = counter * j;
                Helpers.PrintLn($"{counter} x {j} = {result}");
            }

            Helpers.PrintLn("");
        }
    }
}
