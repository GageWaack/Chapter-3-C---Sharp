using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp1;
            double temp2;
            double temp3;

            string temp1String;
            string temp2String;
            string temp3String;

            double conversion8;
            double conversion12;
            double conversion5;



            Write("Please enter number of Fahrenheit at 8 am>>> ");
            temp1String = ReadLine();
            temp1 = Convert.ToDouble(temp1String);



            Write("Please enter number of Fahrenheit at 12 am>>> ");
            temp2String = ReadLine();
            temp2 = Convert.ToDouble(temp2String);


            Write("Please enter number of fahrenheit at 5 pm>>> ");

            temp3String = ReadLine();
            temp3 = Convert.ToDouble(temp3String);


            conversion8 = temp1 * 5 / 9;

            if (temp1 < 100)

                conversion8 = temp1 * 5 / 9;
            if (conversion8 < 100)
                WriteLine("  At 8 it was freezing  ");
            else
                WriteLine("  It was hot at 8 am  ");

            WriteLine("  The degrees at 8 am in celsious was {0}  ", +conversion8);

            conversion12 = temp2 * 5 / 9;
            if (conversion12 < 100)
                WriteLine("  It was freezing at 12 am ");
            else
                WriteLine("  It was hot at 12 am ");

            WriteLine("  The degrees at 12 am in celsius was {0}  ", + conversion12);


            conversion5 = temp3 * 5 / 9;
            if (conversion5 < 100)
                WriteLine("  It was freezing at 5 pm  ");
            else
                WriteLine("  It was hot at  5 pm  ");
            WriteLine("  The degrees at 5 pm in celsius was {0}  ", +conversion5);
        
        }
    }
}
