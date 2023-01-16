using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int workerOne = int.Parse(Console.ReadLine());
            int workerTwo = int.Parse(Console.ReadLine());
            int workerThree = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            int neededHours = 0;
            int answersPerHour = workerOne + workerTwo + workerThree;

            while (studentsCount > 0)
            {
                studentsCount -= answersPerHour;
                neededHours++;

                if (neededHours % 4 == 0)
                {
                    neededHours++;
                }
            }

            Console.WriteLine($"Time needed: {neededHours}h.");
        }
    }
}