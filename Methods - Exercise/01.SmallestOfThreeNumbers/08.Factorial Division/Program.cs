using System;
using System.Linq;

namespace Solution
{
    public static class Program
    {
        static void Main(string[] args)
        {
            double number1 = int.Parse(Console.ReadLine());
            double number2 = int.Parse(Console.ReadLine());

            double division = DivideFactorialSum(number1, number2);



        }
        static double DivideFactorialSum(double number1, double number2)
        {
            double factioralSumOfNumber1 = 1;

            for (double i = number1; i > 1; i--)
            {
                factioralSumOfNumber1 *= i;

            }

            double factioralSumOfNumber2 = 1;

            for (double i = number2; i > 1; i--)
            {
                factioralSumOfNumber2 *= i;

            }

            double division = factioralSumOfNumber1 / factioralSumOfNumber2;
            Console.WriteLine($"{division:f2}");

            return division;
        }
    }
}