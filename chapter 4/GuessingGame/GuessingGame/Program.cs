using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess;
            string guessString;
            int min = 1;
            int max = 11;
            string result = null;
            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(min, max);

            Write("choose a number between 1-10>>> ");
            guessString = ReadLine();
            guess = Convert.ToInt32(guessString);

            if (guess < max && guess >= min)
            {
                if (randomNumber == guess)
                {
                    result = "you win, you guessed " + randomNumber;
                }
                else if (guess > randomNumber)
                {
                    result = "you guessed to high"; }



                else if (guess < randomNumber)
                {
                    result = "you guessed too low";
                }
                else result = "Error";
                WriteLine(result);
                    
                }


            }
        }
    }
