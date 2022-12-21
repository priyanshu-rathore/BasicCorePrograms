using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class VowelConsonant
    {
        public static void vowelConsonant()
        {
            Console.WriteLine("Enter a Alphabet : ");
            string str = Console.ReadLine();

            string[] arr = new string[] { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };

            int n = arr.Length;

            for(int i=0; i<n; i++)
            {
                if(str == arr[i])
                {
                    Console.WriteLine("{0} is a vowel",str);
                }
                else
                {
                    Console.WriteLine("{0} is a consonant", str);
                }
            }
        }
    }
}
