﻿namespace BasicCoreProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Flip coin  2. Leap year");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1: FlipCoin.flipCoin();
                    break;
                case 2: LeapYear.leapYear();
                    break;
            }
        }
    }
}