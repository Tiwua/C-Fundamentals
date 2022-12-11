using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries);

            int health = 100;
            bool notDead = true;

            int tempHealth = 0;
            int currHealth = 0;

            int currBitcoins = 0;
            for (int i = 0; i < rooms.Length; i++)
            {
                string command = rooms[i];
                string[] splitted = command.Split();

                string action = splitted[0];
                int value = int.Parse(splitted[1]);

                if (action == "potion")
                {
                    currHealth = health;
                    tempHealth = health;

                    currHealth += value;
                    if (currHealth <= 100)
                    {
                        health += value;
                        Console.WriteLine($"You healed for {value} hp.");
                        Console.WriteLine($"Current health: {currHealth} hp.");
                    }
                    else if (currHealth > 100)
                    {
                        int healed = 100 - tempHealth;
                        health = 100;
                        Console.WriteLine($"You healed for {healed} hp.");
                        Console.WriteLine($"Current health: {health} hp.");

                    }
                }
                else if (action == "chest")
                {
                    Console.WriteLine($"You found {value} bitcoins.");
                    currBitcoins += value;

                }

                else
                {
                    health -= value;
                    if (health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {action}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        notDead = false;
                        break;
                    }

                    Console.WriteLine($"You slayed {action}.");
                }
            }
            if (notDead)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {currBitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}