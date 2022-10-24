using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            string[] phrases = new string[] { "Excellent product."
                    , "Such a great product.", "I always use that product."
                    , "Best product of this category"
                    , "Exceptional product."
                    , "I can't live without this product." };

            string[] events = new string[] { "Now i feel good."
                    , "I have suceeded with this product."
                    , "Makes miracles."
                    , "I am happy of the results!"
                    , "I cannot believe but now i feel awesome."
                    , "Try it yourself, I am very satisfied"
                    , "I feel great!"};

            string[] authors = new string[] {"Diana"
                     ,"Petya"
                     ,"Stella"
                     ,"Elena"
                     ,"Katya"
                     ,"Iva"
                     ,"Annie"
                     ,"Eva" };

            string[] cities = new string[] {"Burgas"
                     ,"Sofia"
                     ,"Plovdiv"
                     ,"Varna"
                     ,"Ruse"};

            Random phrase = new Random();
            Random event1 = new Random();
            Random author = new Random();
            Random city = new Random();

            for (int i = 1; i <= n; i++)
            {
                int phraseIndex = phrase.Next(0, phrases.Length);
                int eventIndex = phrase.Next(0, events.Length);
                int authorIndex = phrase.Next(0, authors.Length);
                int cityIndex = phrase.Next(0, cities.Length);

                Console.WriteLine($"{phrases[phraseIndex]} {events[eventIndex]} - {cities[cityIndex]}");


            }
        }

    }
}

