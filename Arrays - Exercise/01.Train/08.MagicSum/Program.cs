﻿using System;
using System.Linq;
namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int magicNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == magicNumber)
                    {
                        Console.WriteLine($"{arr[i]} {arr[j]}");

                    }
                }

            }
        }
    }
}