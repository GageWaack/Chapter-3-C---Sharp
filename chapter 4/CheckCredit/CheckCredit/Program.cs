using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CheckCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 5000;
            string priceString;
            int price;

            WriteLine("Please enter a price      ");
            priceString = ReadLine();
            price = Convert.ToInt32(priceString);
            if (price > MAX)
                Write("ERROR YOU ARE OVER LIMIT            ");
            else
                Write("You are not over limit :)       ");
        }
    }
}
