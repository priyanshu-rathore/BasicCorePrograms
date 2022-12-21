using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class FlipCoin
    {
        public static void flipCoin()
        {
            Random random = new Random();

            int head = 0,tail = 0;

            Console.Write("Enter how many times coin should flip : ");
            int n= Convert.ToInt32(Console.ReadLine());

            for(int i=1; i <= n; i++)
            {
                double coin = random.NextDouble();
                if (coin < 0.5)
                {
                    tail++;
                }
                else
                {
                    head++;
                }
            }

            if(tail>head)
            {
                Console.WriteLine("Tails wins");
            }
            else
            {
                Console.WriteLine("Head wins");
            }

            int perTail = (tail * 100) / n;
            int perHead = (head * 100) / n;

            Console.WriteLine("Percentage of Tail flipped {0}% and for Head flipped {1}%",perTail,perHead);
        }
    }
}
