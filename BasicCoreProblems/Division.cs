using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class Division
    {
        public static void divide()
        {
            Console.Write("Enter the dividend :");
            int numerator = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the divisor : ");
            int denominator = Convert.ToInt32(Console.ReadLine());

            int quotient = numerator / denominator;
            int remainder = numerator % denominator;

            Console.WriteLine("Quotient is {0} and remainder is {1}",quotient,remainder);
        }
    }
}
