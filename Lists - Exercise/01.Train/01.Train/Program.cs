using System;
using System.Linq;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> passangers = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            int capacity = int.Parse(Console.ReadLine());

            string command;
            while ((command = Console.ReadLine()) != "end")
            {

                string[] commandArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string cmd = commandArgs[0];
                if (cmd == "Add")
                {
                    int addNumber = int.Parse(commandArgs[1]);
                    passangers.Add(addNumber);
                    continue;
                }
                else
                {
                    int passangersToAdd = int.Parse(commandArgs[0]);

                    for (int i = 0; i < passangers.Count; i++)
                    {
                        if (capacity >= passangers[i] + passangersToAdd)
                        {
                            passangers[i] += passangersToAdd;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(String.Join(" ", passangers));

        }
    }
}