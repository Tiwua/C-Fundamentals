using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> field = Console.ReadLine()
                .Split("@", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int currentPosition = 0;
            string command;
            while ((command = Console.ReadLine()) != "Love!")
            {
                List<string> splittedCommand = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (splittedCommand[0] == "Jump")
                {
                    currentPosition += int.Parse(splittedCommand[1]);
                }
                if (currentPosition > field.Count - 1)
                {
                    currentPosition = 0;
                }
                if (field[currentPosition] == 0)
                {
                    Console.WriteLine($"Place {currentPosition} already had Valentine's day.");
                }
                else
                {
                    field[currentPosition] -= 2;
                    if (field[currentPosition] == 0)
                    {
                        Console.WriteLine($"Place {currentPosition} has Valentine's day.");
                    }
                }
            }
            Console.WriteLine($"Cupid's last position was {currentPosition}.");
            int counter = field.Count(x => x > 0);

            if (field.Sum() == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {counter} places.");
            }

        }
    }
}