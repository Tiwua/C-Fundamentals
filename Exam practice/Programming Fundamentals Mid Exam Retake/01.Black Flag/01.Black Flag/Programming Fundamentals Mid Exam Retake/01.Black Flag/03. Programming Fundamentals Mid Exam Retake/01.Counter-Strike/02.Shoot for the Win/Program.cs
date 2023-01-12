using System;
using System.Linq;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command;
            int count = 0;
            while ((command = Console.ReadLine()) != "End")
            {
                int indexToShoot = int.Parse(command);

                if (indexToShoot >= 0
                    && indexToShoot < targets.Length
                    && targets[indexToShoot] != -1)
                {
                    int power = targets[indexToShoot];
                    targets[indexToShoot] = -1;
                    for (int i = 0; i < targets.Length; i++)
                    {

                        if (targets[i] == -1)
                        {
                            continue;
                        }
                        if (targets[i] > power)
                        {
                            targets[i] -= power;
                        }
                        else
                        {
                            targets[i] += power;
                        }

                    }
                    count++;
                }
            }
            Console.WriteLine($"Shot targets: {count} -> {string.Join(" ", targets)}");
        }
    }
}