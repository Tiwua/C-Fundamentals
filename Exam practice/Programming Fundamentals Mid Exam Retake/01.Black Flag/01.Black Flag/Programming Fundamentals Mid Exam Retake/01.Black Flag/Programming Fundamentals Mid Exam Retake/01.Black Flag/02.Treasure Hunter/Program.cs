using System;
using System.Linq;
using System.Collections.Generic;
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> treasureChest = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();

            while (command != "Yohoho!")
            {
                string[] splittedCommand = command.Split();
                string action = splittedCommand[0];
                if (action == "Loot")
                {
                    for (int i = 1; i < splittedCommand.Length; i++)
                    {
                        if (!treasureChest.Contains(splittedCommand[i]))
                        {
                            treasureChest.Insert(0, splittedCommand[i]);
                        }
                    }
                }
                else if (action == "Drop")
                {
                    int index = int.Parse(splittedCommand[1]);
                    if (index >= 0 && index < treasureChest.Count)
                    {
                        string removedItem = treasureChest[index];
                        treasureChest.RemoveAt(index);
                        treasureChest.Add(removedItem);

                    }
                }
                else if (action == "Steal")
                {
                    List<string> stolen = new List<string>();
                    int count = int.Parse(splittedCommand[1]);

                    if (count < treasureChest.Count)
                    {
                        for (int i = treasureChest.Count - count; i < treasureChest.Count; i++)
                        {
                            stolen.Add(treasureChest[i]);
                        }
                        Console.WriteLine(string.Join(", ", stolen));
                        treasureChest.RemoveRange(treasureChest.Count - count, count);
                    }
                    else
                    {
                        for (int i = 0; i < treasureChest.Count; i++)
                        {
                            stolen.Add(treasureChest[i]);
                        }

                        Console.WriteLine(String.Join(", ", stolen));
                        treasureChest.RemoveRange(0, treasureChest.Count);
                    }
                }

                command = Console.ReadLine();
            }

            if (treasureChest.Count != 0)
            {
                double sum = 0;
                foreach (var item in treasureChest)
                {
                    sum += item.Length;
                }
                double avg = sum / treasureChest.Count;
                Console.WriteLine($"Average treasure gain: {avg:f2} pirate credits.");

            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}