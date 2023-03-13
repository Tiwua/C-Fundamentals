using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string decryptedMessage = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Decode")
            {
                string[] commandArgs = command.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string action = commandArgs[0];

                if (action == "Move")
                {
                    int lettersToMove = int.Parse(commandArgs[1]);

                    string movedLetters = decryptedMessage.Substring(0, lettersToMove);
                    decryptedMessage = decryptedMessage.Remove(0, lettersToMove);
                    decryptedMessage = decryptedMessage + movedLetters;

                }
                else if (action == "Insert")
                {
                    int indexToInsert = int.Parse(commandArgs[1]);
                    string value = commandArgs[2];

                    decryptedMessage = decryptedMessage.Insert(indexToInsert, value);
                }
                else if (action == "ChangeAll")
                {
                    string substring = commandArgs[1];
                    string replacement = commandArgs[2];

                    if (decryptedMessage.Contains(substring))
                    {
                        decryptedMessage = decryptedMessage.Replace(substring, replacement);
                    }
                }
            }
            Console.WriteLine($"The decrypted message is: {decryptedMessage}");
        }
    }
}