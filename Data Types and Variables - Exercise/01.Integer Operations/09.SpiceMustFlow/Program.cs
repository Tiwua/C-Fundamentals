using System;
namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int produced = 0;
            int days = 0;

            if (yield < 100)
            {
                Console.WriteLine($"{days}\n{produced}");
            }
            else
            {
                while (yield >= 100)
                {
                    produced += yield - 26;
                    yield -= 10;
                    days++;
                }

                produced -= 26;

                Console.WriteLine($"{days}\n{produced}");
            }

        }
    }
}