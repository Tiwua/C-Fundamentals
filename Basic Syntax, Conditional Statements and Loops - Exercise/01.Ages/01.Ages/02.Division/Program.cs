using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int division = -1;

            if (num % 10 == 0)
            {

                Console.WriteLine("The number is divisible by 10");
            }
            else if (num % 7 == 0)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else if (num % 6 == 0)
            {
                Console.WriteLine("The number is divisible by 6");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3");
            }
            else if (num % 2 == 0)
            {
                Console.WriteLine("The number is divisible by 2");
            }
            else if (division == -1)
            {
                Console.WriteLine("Not divisible");
            }


        }
    }
}