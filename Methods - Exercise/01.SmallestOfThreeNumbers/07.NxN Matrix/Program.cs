using System;
using System.Linq;

namespace Solution
{
    public static class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int field = PrintSquareNxN(number);


        }

        static int PrintSquareNxN(int number)
        {
            for (int row = 0; row < number; row++)
            {
                for (int line = 0; line < number; line++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
            return number;
        }
    }
}