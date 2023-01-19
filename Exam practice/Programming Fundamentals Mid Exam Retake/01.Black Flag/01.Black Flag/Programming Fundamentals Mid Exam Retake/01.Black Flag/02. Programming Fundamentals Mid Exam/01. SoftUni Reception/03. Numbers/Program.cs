using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            if (numbers.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }

            double averageNum = numbers.Sum() / (double)numbers.Count;
            double matchingNUmbersCOunt = numbers.Where(x => x > averageNum).ToArray().Count();

            if (matchingNUmbersCOunt == 0)
            {
                Console.WriteLine("No");
            }

            else if (numbers.Count < 5)
            {
                Console.WriteLine("Less than 5 numbers");
            }

            else
            {
                var result = numbers.OrderByDescending(x => x).Where(x => x > averageNum).Take(5).ToArray();

                Console.WriteLine(String.Join(" ", result));
            }
        }
    }
}