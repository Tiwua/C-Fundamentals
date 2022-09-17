using System;
using System.Linq;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberArray = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string cmd = commandArgs[0];
                if (cmd == "Delete")
                {
                    int deleteNumber = int.Parse(commandArgs[1]);
                    numberArray.RemoveAll(x => x == deleteNumber);
                    continue;
                }
                if (cmd == "Insert")
                {
                    int insertNumber = int.Parse(commandArgs[1]);
                    int insertIndex = int.Parse(commandArgs[2]);

                    numberArray.Insert(insertIndex, insertNumber);
                    continue;
                }
            }
            Console.WriteLine(String.Join(" ", numberArray));
        }


    }
}