using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameDeux
{
    class Program
    {
        static string WriteToTerminal(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            return input;
        }

        static int GetValidFormat(string message)
        {
            var input = message;
            int number = 0;
            bool wasFormatCorrect = int.TryParse(input, out number);
            while (!wasFormatCorrect)
            {
                Console.WriteLine("Please pick a number, do not use words");
                input = Console.ReadLine();
                wasFormatCorrect = int.TryParse(input, out number);
            }
            return number;
        }

        static void EndingStatement(int userGues, int randoNum, int countt)
        {
            if (userGues == randoNum)
            {
                Console.WriteLine("You win the game, congratulations!");
            }
            else if (countt > 4)
            {
                Console.WriteLine("You lose the game!");
            }
        }

        static void TooLowTooHigh(int whatUserPicked, int datRandom)
        {
            if (whatUserPicked < datRandom)
            {
                Console.WriteLine("Sorry that number is too low, try again");
            }
            else if (whatUserPicked > datRandom)
            {
                Console.WriteLine("Sorry that number is too high, try again");
            }
        }

        static void Main(string[] args)
        {

            var randomNum = new Random().Next(1, 101);
            var count = 0;
            var userGuess = 0;
            var prevGuesses = new int[5];

            WriteToTerminal($"The random number selected is {randomNum}");

            while (count < 5 && userGuess != randomNum)
            { 

                Console.WriteLine("Please pick a number between 1 and 100");
                userGuess = GetValidFormat(Console.ReadLine());

                var beenGuessedBefore = false;
                foreach (var checkGuess in prevGuesses) 
                {   if (userGuess == checkGuess)
                    {
                        beenGuessedBefore = true;
                    }
                }
                if (beenGuessedBefore)
                {
                    Console.WriteLine("You have already guessed that number");
                }
                else
                {
                    prevGuesses[count] = userGuess;

                    TooLowTooHigh(userGuess, randomNum);
                }
                  
                Console.WriteLine("Your past guesses so far are: ");

                foreach (var guessList in prevGuesses)
                {
                    if (guessList != 0)
                    {
                        Console.Write($"{guessList}, ");
                    }

                }

                Console.WriteLine(" ");

                count++;

                EndingStatement(userGuess, randomNum, count);

            }

       




                   




















        }
    }
}
