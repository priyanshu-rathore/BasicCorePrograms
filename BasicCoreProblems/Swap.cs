using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class Swap
    {
        public static void swap()
        {
            Console.WriteLine("Enter the number : ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());    
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("FirstNumber is {0} and SecondNumber is {1}",firstNumber,secondNumber);
            int temp;

            temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;

            Console.WriteLine("After Swapping FirstNumber is {0} and SecondNumber is {1}",firstNumber,secondNumber);

        }
    }
}
