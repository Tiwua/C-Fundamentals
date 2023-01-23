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
            string rawActivationKey = Console.ReadLine();

            string command;

            while ((command = Console.ReadLine()) != "Generate")
            {
                string[] splittedCommand = command.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string action = splittedCommand[0];

                if (action == "Contains")
                {
                    string substring = splittedCommand[1];

                    if (rawActivationKey.Contains(substring))
                    {
                        Console.WriteLine($"{rawActivationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (action == "Flip")
                {
                    string flipInfo = splittedCommand[1];
                    int startIndex = int.Parse(splittedCommand[2]);
                    int endIndex = int.Parse((splittedCommand[3]));

                    string substring = rawActivationKey.Substring(startIndex, endIndex - startIndex);

                    if (flipInfo == "Upper")
                    {
                        substring = substring.ToUpper();
                    }
                    if (flipInfo == "Lower")
                    {
                        substring = substring.ToLower();
                    }

                    rawActivationKey = rawActivationKey.Remove(startIndex, endIndex - startIndex);
                    rawActivationKey = rawActivationKey.Insert(startIndex, substring);

                    Console.WriteLine(rawActivationKey);
                }
                else if (action == "Slice")
                {
                    int startIndex = int.Parse(splittedCommand[1]);
                    int endIndex = int.Parse(splittedCommand[2]);

                    rawActivationKey = rawActivationKey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(rawActivationKey);
                }
            }
            Console.WriteLine($"Your activation key is: {rawActivationKey}");
        }
    }
}