using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    public static class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {

                if (FindSumOfDigits(i) && IncludeOddDigit(i))
                {
                    Console.WriteLine(i);

                }
            }
        }
        static bool FindSumOfDigits(int number)
        {

            int sumOfDigits = 0;

            while (number != 0)
            {
                sumOfDigits += number % 10;
                number /= 10;
            }
            bool isDivisable = sumOfDigits % 8 == 0;

            return isDivisable;
        }

        static bool IncludeOddDigit(int number)
        {
            while (number > 0)
            {
                int currentDigit = number % 10;
                if (currentDigit % 2 == 1)
                {
                    return true;
                }
                number /= 10;
            }
            return false;

        }
    }
}