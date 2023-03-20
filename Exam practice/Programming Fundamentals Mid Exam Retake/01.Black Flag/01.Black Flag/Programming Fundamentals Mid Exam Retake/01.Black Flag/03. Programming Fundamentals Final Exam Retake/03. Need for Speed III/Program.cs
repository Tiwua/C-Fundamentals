using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp4
{
    class Car
    {
        public Car(string name, int mileage, int fuel)
        {
            this.Name = name;
            this.Mileage = mileage;
            this.Fuel = fuel;
        }
        public string Name { get; set; }
        public int Mileage { get; set; }
        public int Fuel { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> carCollection = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carsInput = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);

                string name = carsInput[0];
                int mileage = int.Parse(carsInput[1]);
                int fuel = int.Parse(carsInput[2]);

                carCollection.Add(new Car(name, mileage, fuel));
            }

            string command;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] commandArgs = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string action = commandArgs[0];
                string name = commandArgs[1];

                if (action == "Drive")
                {
                    int mileage = int.Parse(commandArgs[2]);
                    int fuel = int.Parse(commandArgs[3]);

                    Car currCar = carCollection.FirstOrDefault(x => x.Name == name);

                    if (currCar.Fuel >= fuel)
                    {
                        currCar.Mileage += mileage;
                        currCar.Fuel -= fuel;
                        Console.WriteLine($"{name} driven for {mileage} kilometers. {fuel} liters of fuel consumed.");
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    if (currCar.Mileage >= 100000)
                    {
                        Console.WriteLine($"Time to sell the {name}!");
                        carCollection.Remove(currCar);
                    }
                }
                else if (action == "Refuel")
                {
                    int fuel = int.Parse(commandArgs[2]);

                    Car currCar = carCollection.FirstOrDefault(y => y.Name == name);

                    int refueled = currCar.Fuel + fuel >= 75 ? 75 - currCar.Fuel : fuel;
                    currCar.Fuel += refueled;

                    Console.WriteLine($"{name} refueled with {refueled} liters");
                    continue;

                }
                else if (action == "Revert")
                {
                    int km = int.Parse(commandArgs[2]);

                    Car currCar = carCollection.FirstOrDefault(x => x.Name == name);
                    currCar.Mileage -= km;

                    if (currCar.Mileage < 10000)
                    {
                        currCar.Mileage = 10000;
                        continue;
                    }
                    Console.WriteLine($"{name} mileage decreased by {km} kilometers");
                }
            }
            foreach (var car in carCollection)
            {
                Console.WriteLine($"{car.Name} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
            }

        }
    }
}