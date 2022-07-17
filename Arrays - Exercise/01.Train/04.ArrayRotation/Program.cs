using System;
using System.Linq;
namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for (int rot = 1; rot <= rotations; rot++)
            {
                int firstNumber = arr[0];
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[arr.Length - 1] = firstNumber;

            }

            Console.WriteLine(String.Join(" ", arr));



        }
    }
}