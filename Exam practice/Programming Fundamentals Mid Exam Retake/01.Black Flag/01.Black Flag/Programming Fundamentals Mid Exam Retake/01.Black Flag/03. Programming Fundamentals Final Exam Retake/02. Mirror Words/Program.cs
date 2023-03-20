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

            string pattern = @"(@|#)(?<firstWord>[a-zA-Z]{3,})(\1)(\1)(?<secondWord>[a-zA-Z]{3,})(\1)";
            List<string[]> wordPairs = new List<string[]>();

            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match match in matches)
            {
                string leftWord = match.Groups["firstWord"].Value;
                string rightWord = string.Join("", match.Groups["secondWord"].Value.Reverse());

                if (leftWord == rightWord)
                {
                    wordPairs.Add(new string[2] { match.Groups["firstWord"].Value, match.Groups["secondWord"].Value });
                }

            }
            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");

            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }

            if (wordPairs.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(String.Join(", ", wordPairs.Select(x => $"{x[0]} <=> {x[1]}")));
            }
        }
    }
}