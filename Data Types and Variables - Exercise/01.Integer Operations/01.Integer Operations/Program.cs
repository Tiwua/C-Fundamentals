using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            int result1 = num1 + num2;
            int result2 = result1 / num3;
            int result3 = result2 * num4;

            Console.WriteLine($"{result3}");

        }
    }
}
