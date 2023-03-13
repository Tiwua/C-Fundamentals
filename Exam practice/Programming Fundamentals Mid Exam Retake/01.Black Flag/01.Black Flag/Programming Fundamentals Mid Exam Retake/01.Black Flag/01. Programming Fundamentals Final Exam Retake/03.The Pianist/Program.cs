using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp6
{
    class PianoPieces
    {
        public PianoPieces(string piece, string composer, string key)
        {
            this.Piece = piece;
            this.Composer = composer;
            this.Key = key;
        }
        public string Piece { get; set; }

        public string Composer { get; set; }

        public string Key { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPieces = int.Parse(Console.ReadLine());

            List<PianoPieces> pianoCollection = new List<PianoPieces>();


            for (int i = 0; i < numberOfPieces; i++)
            {
                string pieces = Console.ReadLine();
                string[] input = pieces.Split('|');

                string piece = input[0];
                string composer = input[1];
                string key = input[2];

                pianoCollection.Add(new PianoPieces(piece, composer, key));
            }
            string command;
            while ((command = Console.ReadLine()) != "Stop")
            {

                string[] splittedCommand = command
                    .Split('|', StringSplitOptions.RemoveEmptyEntries);
                string action = splittedCommand[0];
                string piece = splittedCommand[1];

                if (action == "Add")
                {
                    string composer = splittedCommand[2];
                    string key = splittedCommand[3];
                    PianoPieces currentPianoPiece = new PianoPieces(piece, composer, key);

                    if (pianoCollection.FirstOrDefault(x => x.Piece == piece) == null)
                    {
                        pianoCollection.Add(currentPianoPiece);
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if (action == "Remove")
                {
                    var itemToRemove = pianoCollection.FirstOrDefault(x => x.Piece == piece);
                    if (itemToRemove != null)
                    {
                        pianoCollection.Remove(itemToRemove);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }

                }
                else if (action == "ChangeKey")
                {
                    string newKey = splittedCommand[2];

                    var itemToCHangeKey = pianoCollection.FirstOrDefault(x => x.Piece == piece);

                    if (itemToCHangeKey != null)
                    {
                        itemToCHangeKey.Key = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
            }

            foreach (var song in pianoCollection)
            {
                Console.WriteLine($"{song.Piece} -> Composer: {song.Composer}, Key: {song.Key}");
            }
        }
    }
}