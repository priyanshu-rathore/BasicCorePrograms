using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class LargestNumber
    {
        public static void largestNumber()
        {
            Console.WriteLine("Enter the 3 Numbers");
            int[] arr = new int[3];
            arr[0] = Convert.ToInt32(Console.ReadLine());
            arr[1] = Convert.ToInt32(Console.ReadLine());
            arr[2] = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+ " ");
            }

            Array.Sort(arr);

            Console.WriteLine("{0} is the Largest Number of the 3 Number", arr[2]);

        }
    }
}
