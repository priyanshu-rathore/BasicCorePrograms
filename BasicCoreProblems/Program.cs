namespace BasicCoreProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(1. Flip coin  (2. Leap year  (3. Power of 2  (4. Harmonic Progression  (5. Factors");
            Console.WriteLine("(6. Division   (7. Swap Number (8. Odd Even   (9. Alphabet check        (10. Largest number");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1: FlipCoin.flipCoin();
                    break;
                case 2: LeapYear.leapYear();
                    break;
                case 3: PowerOF2.powerof2();
                    break;
                case 4: HarmonicProgression.Hp();
                    break;
                case 5: Factors.factors();
                    break;
                case 6: Division.divide();
                    break;
                case 7: Swap.swap();
                    break;
                case 8: EvenOdd.evenOdd();
                    break;
                case 9: VowelConsonant.vowelConsonant();
                    break;
                case 10: LargestNumber.largestNumber();
                    break;

            }
        }
    }
}