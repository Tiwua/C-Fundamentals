using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double food = double.Parse(Console.ReadLine());
            double hay = double.Parse(Console.ReadLine());
            double cover = double.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());

            double foodInGrams = food * 1000;
            double hayInGrams = hay * 1000;
            double coverInGrams = cover * 1000;
            double weightInGrams = weight * 1000;

            int counter = 0;

            for (int i = 1; i <= 30; i++)
            {
                foodInGrams -= 300;
                counter++;

                if (counter % 2 == 0)
                {
                    hayInGrams -= (foodInGrams * 0.05);
                }
                if (counter % 3 == 0)
                {
                    double weightToCover = weightInGrams / 3;
                    coverInGrams -= weightToCover;
                }
            }

            double foodKg = foodInGrams / 1000;
            double hayKg = hayInGrams / 1000;
            double coverKg = coverInGrams / 1000;

            if (foodKg >= 0 && hayKg >= 0 && coverKg >= 0)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodKg:f2}, Hay: {hayKg:f2}, Cover: {coverKg:f2}.");
            }
            else
            {
                Console.WriteLine("Merry must go to the pet store!");
            }
        }
    }
}