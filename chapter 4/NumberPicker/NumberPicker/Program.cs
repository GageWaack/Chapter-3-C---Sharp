using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NumberPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string numberString;
            
            Write("Please enter a number 1 2 or 3   ");
            numberString = ReadLine();
            number = Convert.ToInt32(numberString);

            if (number == 2)
            {
                Write("You win!!!   ");
            }
            else if (number == 1)
            {
                Write("YOU LOSE   ");
            }
            else if (number == 3)
            {
                Write("YOU LOSE  ");
            }
            else 
            {
                Write("ERROR 404 NOT FOUND     ");
            }
        }
    }
}
