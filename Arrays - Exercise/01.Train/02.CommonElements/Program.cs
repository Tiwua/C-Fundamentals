using System;
using System.Linq;
using System.Numerics;
namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string[] secondInput = Console.ReadLine()
                .Split(' ')
                .ToArray();



            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < secondInput.Length; j++)
                {
                    if (input[i] == secondInput[j])
                    {
                        Console.Write($"{input[i]} ");
                    }
                }
            }

        }
    }
}