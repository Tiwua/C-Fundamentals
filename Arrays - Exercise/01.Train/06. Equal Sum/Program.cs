using System;
using System.Linq;
namespace EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool isFound = false;

            for (int i = 0; i < arr.Length; i++)
            {
                int rightSum = 0;
                int leftSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += arr[j];
                }

                for (int j = arr.Length - 1; j > i; j--)
                {
                    rightSum += arr[j];
                }

                if (leftSum == rightSum && !isFound)
                {
                    Console.WriteLine(i);
                    isFound = true;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("no");
            }


        }
    }
}