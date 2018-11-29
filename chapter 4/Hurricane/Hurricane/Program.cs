using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Hurricane
{
    class Program
    {
        static void Main(string[] args)
        {
            


           
            int catagory;
            string catagoryString;

            Write("Enter Wind speeds        ");
            catagoryString = ReadLine();
            catagory = Convert.ToInt32(catagoryString);

            if (catagory >= 157)
                Write("It is a catagory 5 hurricane        ");
            else if (catagory >= 130)
                Write("it is a catagory 4 hurricane        ");
            else if (catagory >= 111)
                Write("it is a catagory 3 hurricane        ");
            else if (catagory >= 96)
                Write("It is a catagory 2 hurricane        ");
            else if (catagory >= 74)
                Write("It is a catagory 1 hurricane        ");
            else
                Write("It is not a hurricane         ");
        }
    }
}
