using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Travel")
            {
                string[] commandArg = command.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string action = commandArg[0];

                if (action == "Add Stop")
                {
                    int indexStop = int.Parse(commandArg[1]);
                    string place = commandArg[2];

                    if (indexStop >= 0 && indexStop < stops.Length)
                    {
                        stops = stops.Insert(indexStop, place);
                    }

                    Console.WriteLine(stops);
                }

                else if (action == "Remove Stop")
                {
                    int startIndex = int.Parse(commandArg[1]);
                    int endIndex = int.Parse((commandArg[2]));

                    if (startIndex >= 0 && endIndex < stops.Length)
                    {
                        stops = stops.Remove(startIndex, endIndex - startIndex + 1);
                    }

                    Console.WriteLine(stops);

                }
                else if (action == "Switch")
                {
                    string oldString = commandArg[1];
                    string newString = commandArg[2];

                    if (stops.Contains(oldString))
                    {
                        stops = stops.Replace(oldString, newString);
                    }

                    Console.WriteLine(stops);
                }

            }
            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");

        }
    }
}