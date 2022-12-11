using System;
using System.Linq;
using System.Collections.Generic;
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());


            int counter = 0;
            double totalPlunder = 0;
            for (int i = 1; i <= days; i++)
            {
                totalPlunder += dailyPlunder;
                counter++;
                if (counter % 3 == 0)
                {
                    totalPlunder += (dailyPlunder * 0.5);
                }
                if (counter % 5 == 0)
                {
                    double lostPlunder = (totalPlunder * 0.3);
                    totalPlunder -= lostPlunder;
                }
            }
            if (totalPlunder >= expectedPlunder)
            {

                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {
                double percentage = totalPlunder / expectedPlunder * 100;
                Console.WriteLine($"Collected only {percentage:f2}% of the plunder.");
            }
        }
    }
}