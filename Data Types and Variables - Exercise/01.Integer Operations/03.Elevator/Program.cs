using System;

namespace _09.YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;

            if (type == "Students")
            {
                if (day == "Friday")
                {
                    price = 8.45;
                }
                if (day == "Saturday")
                {
                    price = 9.80;
                }
                if (day == "Sunday")
                {
                    price = 10.46;
                }
            }
            else if (type == "Business")
            {
                if (day == "Friday")
                {
                    price = 10.90;
                }
                if (day == "Saturday")
                {
                    price = 15.60;
                }
                if (day == "Sunday")
                {
                    price = 16;
                }
            }
            else if (type == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15;
                }
                if (day == "Saturday")
                {
                    price = 20;
                }
                if (day == "Sunday")
                {
                    price = 22.50;
                }
            }

            double totalPrice = people * price;
            double discount = 0.00;

            if (type == "Students" && people >= 30)
            {
                discount = totalPrice * 0.15;
            }
            if (type == "Business" && people >= 100)
            {
                discount = 10 * price;
            }
            if (type == "Regular" && people >= 10 && people <= 20)
            {
                discount = totalPrice * 0.05;
            }

            Console.WriteLine($"Total price: {totalPrice - discount:f2}");
        }

    }
}
