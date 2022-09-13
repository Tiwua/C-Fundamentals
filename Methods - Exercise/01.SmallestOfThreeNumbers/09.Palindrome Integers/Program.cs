using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    public static class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            IsTheNumberPalindrome(command);

        }

        static void IsTheNumberPalindrome(string command)
        {
            string reversed = string.Empty;

            while (command != "END")
            {
                command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                for (int i = command.Length - 1; i >= 0; i--)
                {
                    reversed += command[i];
                }

                if (reversed != command)
                {
                    Console.WriteLine("false");
                }
                else
                {
                    Console.WriteLine("true");
                }
                reversed = String.Empty;
            }
        }
    }
}