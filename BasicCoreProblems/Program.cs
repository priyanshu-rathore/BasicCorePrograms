namespace BasicCoreProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Flip coin");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1: FlipCoin.flipCoin();
                    break;
            }
        }
    }
}