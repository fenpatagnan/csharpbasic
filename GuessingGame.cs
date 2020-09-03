using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasics_1
{
    class GuessingGame
    {
        private const int SecretNumber = 12;
        static int GuessLimit = 5;
         

        public static void GuessTheNumber()
        {
            Helpers.PrintLn($"Find the secret number,please enter your guess:");

            List<int> guessList = new List<int>();

            while (true)
            {
                int guess = Helpers.GetIntInput();

                bool isNumCorrect = CheckNumber(guess);

                if (isNumCorrect)
                {
                    Helpers.Print("Great! You have guessed the number correctly!");
                    break;

                }

                bool isExceeds = GuessExceeds(guess, guessList);

                if (isExceeds)
                {
                    break;
                }

                GuessIsLarge(guess);

                GuessIsSmall(guess);

            }

        }

        static bool CheckNumber(int guess)
        {
            if(guess == SecretNumber)
            {
                return true;
            }
            return false;
        }

        static bool GuessExceeds(int guess, List<int> guessList)
        {
            
            int numberTries = 0;

            if (!guessList.Contains(guess))
            {
                guessList.Add(guess);
                numberTries++;
            }

            if(guessList.Count == GuessLimit && !CheckNumber(guess))
            {
                Helpers.PrintLn("\n**Oops! You have reached the maximum number of tries.**\n");
                return true;
            }

            return false;
            
        }

        static bool GuessIsSmall(int guess)
        {
            if(guess < SecretNumber)
            {
                Helpers.PrintLn("Uh Oh! The number you've entered is too small");
                return true;
            }
            return false;
        }

        static bool GuessIsLarge(int guess)
        {
            if (guess > SecretNumber)
            {
                Helpers.PrintLn("Uh Oh! The number you've entered is too large");
                return true;
            }
            return false;
        }






    }
}
