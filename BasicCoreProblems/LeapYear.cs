using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BasicCoreProblems
{
    internal class LeapYear
    {
        public static void leapYear()
        {
            Console.Write("Enter year : ");
            int year = Convert.ToInt32(Console.ReadLine());

            if(year > 999 && year < 10000)
            {
                if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                {
                    Console.WriteLine("Year is a leap year");
                }
                else
                {
                    Console.WriteLine("Year is not a leap year");
                }
            }
            else
            {
                Console.WriteLine("Error Enter 4 digit number only");
            }
        }
    }
}
