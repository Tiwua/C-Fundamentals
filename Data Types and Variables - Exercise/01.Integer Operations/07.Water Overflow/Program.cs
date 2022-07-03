using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            int waterTank = 255;


            int firstLine = int.Parse(Console.ReadLine());

            for (int i = 1; i <= firstLine; i++)
            {
                int lines = int.Parse(Console.ReadLine());

                if (lines <= waterTank)
                {
                    waterTank -= lines;
                }
                else

                {
                    Console.WriteLine("Insufficient capacity!");

                }
            }
            int litesLeft = 255 - waterTank;

            Console.WriteLine($"{litesLeft}");





        }
    }
}