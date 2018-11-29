using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace RockPaperScissors2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rock = 1;
            int paper = 2;
            int scissors = 3;
            string userString;
            int user;
           
            
            int min = 1;
            int max = 4;
            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(min, max);

            Write ("please enter 1 for rock, 2 for paper or 3 for scissors    ");
            userString = ReadLine();
            user = Convert.ToInt32(userString);

            if (user == rock)
            {
                if (randomNumber == rock)
                {
                    Write("tie      ");
                }
                else if (randomNumber == paper)
                {
                    Write("lost    ");
                }
                else
                    Write("win     ");
            }
            else if (user == paper)
            {
                if (randomNumber == paper)
                {
                    Write("Tie     ");
                }
                else if (randomNumber == scissors)
                {
                    Write("Loss     ");
                }
                else
                    Write("Win     ");
            }
            else if (user == scissors) {
                if (randomNumber == scissors)
                {
                    Write("Tie      ");
                }
                else if (randomNumber == rock)
                {
                    Write("Loss      ");
                }
                else
                    Write("Win       ");
            }

        }
    }
}
