using System;
using System.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string word = Console.ReadLine();

            int vowelsCount = CountVowels(word);

            Console.WriteLine(vowelsCount);

        }
        static int CountVowels(string word)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            int vowelsCount = 0;
            foreach (char ch in word.ToLower())
            {
                if (vowels.Contains(ch))
                {
                    vowelsCount++;
                }
            }
            return vowelsCount;

        }
    }
}
