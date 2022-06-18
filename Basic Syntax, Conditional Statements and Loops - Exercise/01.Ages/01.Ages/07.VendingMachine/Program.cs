using System;

namespace _7.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tempCoins = 0;
            double accumulatedCoins = 0;
            string enteredValue = string.Empty;

            enteredValue = Console.ReadLine();
            do
            {
                tempCoins = double.Parse(enteredValue);

                if (tempCoins == 0.1 || tempCoins == 0.2 || tempCoins == 0.5 || tempCoins == 1 || tempCoins == 2)
                {
                    accumulatedCoins += tempCoins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {tempCoins}");
                }

                enteredValue = Console.ReadLine();

            } while (enteredValue != "Start");

            double priceNuts = 2.0;
            double priceWater = 0.7;
            double priceCrisps = 1.5;
            double priceSoda = 0.8;
            double priceCoke = 1.0;

            enteredValue = string.Empty;
            tempCoins = 0;
            double dark = 0;

            enteredValue = Console.ReadLine();

            do
            {
                enteredValue = enteredValue.ToLower();

                switch (enteredValue)
                {
                    case "nuts": tempCoins += priceNuts; dark = 2.0; break;
                    case "water": tempCoins += priceWater; dark = 0.7; break;
                    case "crisps": tempCoins += priceCrisps; dark = 1.5; break;
                    case "soda": tempCoins += priceSoda; dark = 0.8; break;
                    case "coke": tempCoins += priceCoke; dark = 1.0; break;
                    default: Console.WriteLine($"Invalid product"); break;
                }

                if (enteredValue == "nuts" || enteredValue == "water" || enteredValue == "crisps" || enteredValue == "soda" || enteredValue == "coke")
                {
                    if (accumulatedCoins >= tempCoins)
                    {
                        if (accumulatedCoins != 0)
                        {
                            Console.WriteLine($"Purchased {enteredValue}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, not enough money");
                        tempCoins -= dark;
                    }
                }
                enteredValue = Console.ReadLine();
            } while (enteredValue != "End");

            Console.WriteLine($"Change: {(accumulatedCoins - tempCoins):F2}");
        }
    }
}