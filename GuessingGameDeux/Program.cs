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

        static void Main(string[] args)
        {

            var randomNum = new Random().Next(1, 101);
            WriteToTerminal($"The random number selected is {randomNum}");
            string rawInput = WriteToTerminal("Try and guess a number between 1 and 100");
            GetValidFormat(rawInput);

           












        }
    }
}
