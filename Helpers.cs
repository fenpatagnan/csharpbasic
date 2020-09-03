using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasics_1
{
    class Helpers
    {
        public static void PrintStringArr(string[] ArrayList)
        {
            Console.WriteLine($"{string.Join(",", ArrayList)}");
        }

        public static void PrintIntArr(int[] ArrayList)
        {
            Console.WriteLine($"{string.Join(",", ArrayList)}");
        }

        public static void PrintLn(string str)
        {
            Console.WriteLine(str);
        }

        public static void Print(string str)
        {
            Console.Write(str);
        }

        public static string GetStrInput()
        {
            return Console.ReadLine();
        }

        public static int GetIntInput()
        {
            int input = 0;

            try
            {
               input = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Helpers.Print(e.Message);
            } 
            
            return input;

        }




    }
}
