using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();


        string pattern = @"([#|])(?<product>[A-Za-z\s]+)\1(?<date>[0-9]{2}\/[0-9]{2}\/[0-9]{2})\1(?<calories>[0-9]+)\1";

        int totalCaloriesFromFood = 0;
        MatchCollection matches = Regex.Matches(input, pattern);

        foreach (Match match in matches)
        {

            int totalCalories = (int.Parse)(match.Groups["calories"].Value);
            totalCaloriesFromFood += totalCalories;


        }
        int daysToLast = totalCaloriesFromFood / 2000;
        Console.WriteLine($"You have food to last you for: {daysToLast} days!");

        foreach (Match match in matches)
        {
            Console.WriteLine($"Item: {match.Groups["product"].Value}, Best before: {match.Groups["date"].Value}, Nutrition: {match.Groups["calories"].Value}");
        }

    }
}