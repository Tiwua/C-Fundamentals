using System;
using System.Linq;
using System.Collections.Generic;

namespace Progam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string action = cmdArgs[0];

                if (action == "Add")
                {
                    int numberToAdd = int.Parse(cmdArgs[1]);
                    numbers.Add(numberToAdd);
                    continue;
                }

                else if (action == "Insert")
                {
                    int numberToInsertet = int.Parse(cmdArgs[1]);
                    int indexToInsert = int.Parse(cmdArgs[2]);

                    if (!IsIndexValid(numbers, indexToInsert))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.Insert(indexToInsert, numberToInsertet);
                    continue;
                }
                else if (action == "Remove")
                {
                    int removeIndex = int.Parse(cmdArgs[1]);

                    if (!IsIndexValid(numbers, removeIndex))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(removeIndex);
                }
                else if (action == "Shift")
                {
                    string direction = cmdArgs[1];
                    int numToShift = int.Parse(cmdArgs[2]);

                    if (direction == "right")
                    {
                        ShiftRight(numbers, numToShift);
                    }
                    if (direction == "left")
                    {
                        ShiftLeft(numbers, numToShift);
                    }
                }
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
        static bool IsIndexValid(List<int> numbers, int index)
        {
            return index >= 0 && index < numbers.Count;
        }

        static void ShiftRight(List<int> numbers, int numToShift)
        {
            int exactRotations = numToShift % numbers.Count;
            for (int i = 1; i <= exactRotations; i++)
            {
                int lastNumber = numbers.Last();
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, lastNumber);
            }
        }

        static void ShiftLeft(List<int> numbers, int numToShift)
        {
            int exactRotations = numToShift % numbers.Count;
            for (int i = 1; i <= exactRotations; i++)
            {
                int firstNumber = numbers.First();
                numbers.Remove(firstNumber);
                numbers.Add(firstNumber);
            }
        }


    }
}