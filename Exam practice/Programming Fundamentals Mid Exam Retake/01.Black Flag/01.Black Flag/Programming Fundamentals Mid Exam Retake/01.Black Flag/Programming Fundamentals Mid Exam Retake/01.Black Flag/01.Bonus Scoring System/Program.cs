using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int bonus = int.Parse(Console.ReadLine());

            double bestBonus = 0;
            int bestAttends = 0;

            for (int i = 0; i < students; i++)
            {
                int attendances = int.Parse(Console.ReadLine());

                double totalBonus = ((1.0 * attendances / lectures) * (5 + bonus));

                if (bestBonus < totalBonus)
                {
                    bestBonus = totalBonus;
                    bestAttends = attendances;
                }

            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(bestBonus)}.");
            Console.WriteLine($"The student has attended {bestAttends} lectures.");
        }
    }
