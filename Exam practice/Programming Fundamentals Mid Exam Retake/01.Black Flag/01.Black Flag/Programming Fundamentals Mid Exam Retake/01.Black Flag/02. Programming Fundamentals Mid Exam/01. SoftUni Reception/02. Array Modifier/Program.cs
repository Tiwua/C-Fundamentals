using System;
using System.Linq;

namespace Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int[] input = line.Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            string[] commandSplit = command.Split();
            while (command != "end")
            {
                if (commandSplit[0] == "swap")
                {
                    int index1 = int.Parse(commandSplit[1]);
                    int index2 = int.Parse(commandSplit[2]);
                    int currentValue = input[index1];

                    input[index1] = input[index2];
                    input[index2] = currentValue;
                }
                else if (commandSplit[0] == "multiply")
                {
                    int index1 = int.Parse(commandSplit[1]);
                    int index2 = int.Parse(commandSplit[2]);
                    input[index1] = input[index1] * input[index2];
                }
                else if (commandSplit[0] == "decrease")
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        input[i] -= 1;
                    }
                }

                command = Console.ReadLine();
                commandSplit = command.Split();
            }
            Console.WriteLine(String.Join(", ", input));
        }
    }
}