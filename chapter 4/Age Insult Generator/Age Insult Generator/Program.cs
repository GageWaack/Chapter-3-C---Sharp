using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Age_Insult_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string agestring;
            string yesString;
            int yes;
            Write("Welcome to the famous Age Insult Generator");
            Write(" please enter your age");
            agestring = ReadLine();
            age = Convert.ToInt32(agestring);

            if (age < 18)
            {
                Write("You are a minor, HAHAHHAHAHAHAH. And you cannot vote.");
            }
            else if (age >= 18 && age < 25)
            {
                Write("You should be in college or done with college by now. Do not be a dead beat");
            }
            else if (age >= 25 && age < 32)
            {
                Write("Do you have a job");
                yesString = ReadLine();
                yes = Convert.ToInt32(yesString);
                if (yes == 1)
                    Write("Good for you");
                else
                    Write("Get a job you rat");

            }
            else if (age >= 32 && age < 42)
            {
                Write("You are getting old ");
            }
            else if (age >= 42 && age < 60)
            {
                Write("Why are you doing this to yourself old man ");
            }

        }
    }
}
    

