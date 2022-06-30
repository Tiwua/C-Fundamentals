using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int lastNumber = int.Parse(Console.ReadLine());

            for (int i = firstNumber; i <= lastNumber; i++)
            {
                char digit = (char)i;
                Console.Write($"{digit} ");
            }





        }
    }
}