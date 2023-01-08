using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine()
                .Split("!", StringSplitOptions.RemoveEmptyEntries).ToList();

            string command;
            while ((command = Console.ReadLine()) != "Go Shopping!")
            {
                string[] splittedCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = splittedCommand[0];
                if (action == "Urgent")
                {
                    string item = splittedCommand[1];
                    if (groceries.Contains(item))
                    {
                        continue;
                    }

                    groceries.Insert(0, item);

                }
                else if (action == "Unnecessary")
                {
                    string item = splittedCommand[1];
                    if (groceries.Contains(item))
                    {
                        groceries.Remove(item);
                    }
                    continue;
                }
                else if (action == "Correct")
                {
                    string oldItem = splittedCommand[1];
                    string newItem = splittedCommand[2];

                    if (groceries.Contains(oldItem))
                    {

                        groceries.FindIndex(x => x == oldItem);

                        int oldItemIndex = groceries.IndexOf(oldItem);
                        groceries.Remove(oldItem);
                        groceries.Insert(oldItemIndex, newItem);
                    }
                    continue;
                }
                else if (action == "Rearrange")
                {
                    string item = splittedCommand[1];
                    if (groceries.Contains(item))
                    {
                        string renewedItem = item;
                        groceries.Remove(item);
                        groceries.Add(item);

                    }
                }
            }
            Console.WriteLine(String.Join(", ", groceries));
        }
    }
}