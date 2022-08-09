using System;
using System.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int minLength = 6;
            const int maxLength = 10;
            const int minDigits = 2;

            string password = Console.ReadLine();

            bool isPasswordValid = ValidatePassword(password, minLength, maxLength, minDigits);

            if (isPasswordValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool ValidatePassword(string password, int minLength, int maxLength, int minDigitCount)
        {
            bool isPasswordValid = true;
            if (!ValidatePasswordByCharacter(password, minLength, maxLength))
            {
                Console.WriteLine($"Password must be between {minLength} and {maxLength} characters");
                isPasswordValid = false;
            }
            if (!ValidatePasswordOfLettersAndDigits(password))
            {
                Console.WriteLine($"Password must consist only of letters and digits");
                isPasswordValid = false;
            }
            if (!ValidatePasswordOfDigits(password, minDigitCount))
            {
                Console.WriteLine($"Password must have at least {minDigitCount} digits");
                isPasswordValid = false;
            }
            return isPasswordValid;
        }

        static bool ValidatePasswordByCharacter(string password, int maxLength, int minLength)
        {
            if (password.Length <= minLength && password.Length >= maxLength)
            {
                return true;
            }
            return false;
        }
        static bool ValidatePasswordOfLettersAndDigits(string password)
        {
            foreach (char ch in password)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }
        static bool ValidatePasswordOfDigits(string password, int minDigitCount)
        {
            int digitsCount = 0;
            foreach (char ch in password)
            {
                if (Char.IsDigit(ch))
                {
                    digitsCount++;

                }
            }
            return digitsCount >= minDigitCount;
        }


    }
}
