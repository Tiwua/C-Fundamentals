using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split("|")
                .Reverse()
                .ToList();

            List<string> resultList = new List<string>();

            foreach (var element in list)
            {
                resultList.AddRange(element.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList());
            }

            Console.WriteLine(String.Join(" ", resultList));
        }
    }
}