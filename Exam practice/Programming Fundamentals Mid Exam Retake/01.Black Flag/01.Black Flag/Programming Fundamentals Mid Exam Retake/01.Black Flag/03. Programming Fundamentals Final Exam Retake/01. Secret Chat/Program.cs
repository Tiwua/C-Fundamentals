using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp4
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Reveal")
            {
                string[] splittedCommand = command
                    .Split(":|:", StringSplitOptions.RemoveEmptyEntries);

                string action = splittedCommand[0];

                if (action == "InsertSpace")
                {
                    int indexToInsert = int.Parse(splittedCommand[1]);

                    input = input.Insert(indexToInsert, " ");

                }
                else if (action == "Reverse")
                {
                    string substring = splittedCommand[1];
                    if (input.Contains(substring))
                    {
                        int indexToCut = input.IndexOf(substring);
                        input = input.Remove(indexToCut, substring.Length);
                        input = input + string.Join("", substring.Reverse());
                    }
                    else
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                }
                else if (action == "ChangeAll")
                {
                    string substring = splittedCommand[1];
                    string replacement = splittedCommand[2];

                    input = input.Replace(substring, replacement);
                }
                Console.WriteLine(input);
            }
            Console.WriteLine($"You have a new text message: {input}");
        }
    }
}