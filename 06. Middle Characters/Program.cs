using System;
namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            if (word.Length % 2 == 0)
            {
                GetMiddleOfWordEven(word);

            }
            else if (word.Length % 2 != 0)
            {
                GetMiddleOfWordOdd(word);
            }

        }

        static int GetMiddleOfWordOdd(string word)
        {
            int length = word.Length;
            int middle = length / 2;

            Console.WriteLine(word[middle]);
            return middle;
        }

        static int GetMiddleOfWordEven(string word)
        {
            int length = word.Length;
            int middle = length / 2;

            Console.WriteLine($"{word[middle - 1]}{word[middle]}");
            return middle;
        }



    }
}