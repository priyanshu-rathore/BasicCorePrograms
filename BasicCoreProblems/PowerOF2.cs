using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class PowerOF2
    {
        public static void powerof2()
        {
            Console.Write("Enter the Number : ");
            int n = Convert.ToInt32(Console.ReadLine());    

            if(n == 0)
            {
                Console.WriteLine("2 ^ 0 = 1");
            }

            int pow = 1;

            for(int i = 1; i <= n; i++)
            {
                pow *= 2;
                Console.WriteLine("2 ^ {0} = {1}",i,pow);
            }
        }
    }
}
