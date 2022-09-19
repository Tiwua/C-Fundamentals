using System;
using System.Linq;
using System.Collections.Generic;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();

            for (int i = 0; i < number; i++)
            {

                string[] command = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = command[0];

                if (command.Length == 3)
                {

                    if (list.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }

                    list.Add(name);

                }

                else if (command.Length == 4)
                {
                    if (!list.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                    list.Remove(name);
                }

            }
            Console.WriteLine(String.Join(Environment.NewLine, list));



        }


    }
}