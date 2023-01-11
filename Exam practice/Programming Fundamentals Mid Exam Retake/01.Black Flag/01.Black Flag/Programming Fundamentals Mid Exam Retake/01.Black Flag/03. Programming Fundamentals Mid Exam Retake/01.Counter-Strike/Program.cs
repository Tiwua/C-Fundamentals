using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            string command = string.Empty;
            int count = 0;



            while ((command = Console.ReadLine()) != "End of battle")
            {
                int distance = int.Parse(command);

                if (energy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {count} won battles and {energy} energy");
                    return;
                }
                count++;
                energy -= distance;
                if (count % 3 == 0)
                {
                    energy += count;
                }
            }
            Console.WriteLine($"Won battles: {count}. Energy left: {energy}");

        }
    }
}