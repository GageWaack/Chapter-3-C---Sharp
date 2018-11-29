using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            int GPA;
            int test;
            string GPAstring;
            string testString;


            Write ("Enter GPA      ");
            GPAstring = ReadLine();
            GPA = Convert.ToInt32(GPAstring);

            Write("Enter test score     ");
            testString = ReadLine();
            test = Convert.ToInt32(testString);

            if (GPA >= 3.0 || test >= 60)
                if (GPA <= 3.0 || test >= 80)
                    Write("You passed    ");
                else Write("Reject        ");
        }
    }
}
