using System;

namespace Solution
{
    public static class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            int smallestNumber = CalculateSmallestNumber(number, number2, number3);
            Console.WriteLine(smallestNumber);

        }

        static int CalculateSmallestNumber(int number, int number2, int number3)
        {
            int smallestNumber = 0;

            if (number < number2 && number < number3)
            {
                smallestNumber = number;

            }

            else if (number2 < number && number2 < number3)
            {
                smallestNumber = number2;
            }

            else
            {
                smallestNumber = number3;
            }

            return smallestNumber;

        }
    }
}