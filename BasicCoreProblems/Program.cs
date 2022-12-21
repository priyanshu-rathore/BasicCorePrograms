namespace BasicCoreProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(1. Flip coin  (2. Leap year  (3. Power of 2  (4. Harmonic Progression  (5. Factors");
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

            }
        }
    }
}