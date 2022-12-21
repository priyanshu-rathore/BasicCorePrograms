namespace BasicCoreProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Flip coin  2. Leap year  3. Power of 2");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1: FlipCoin.flipCoin();
                    break;
                case 2: LeapYear.leapYear();
                    break;
                case 3: PowerOF2.powerof2();
                    break;
            }
        }
    }
}