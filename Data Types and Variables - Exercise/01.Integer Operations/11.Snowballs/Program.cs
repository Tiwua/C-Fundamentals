using System;
using System.Numerics;
namespace SnowBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballCount = int.Parse(Console.ReadLine());

            int highestSnoballSnow = 0;
            int highestSnowBallTime = 0;
            int highestSnowBallQuality = 0;
            BigInteger highestSnowBallValue = BigInteger.Zero; ;


            for (int i = 0; i < snowballCount; i++)
            {

                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                int snowballDivide = snowballSnow / snowballTime;
                BigInteger snowBallValue = BigInteger.Pow(snowballDivide, snowballQuality);

                if (snowBallValue >= highestSnowBallValue)
                {
                    highestSnoballSnow = snowballSnow;
                    highestSnowBallTime = snowballTime;
                    highestSnowBallQuality = snowballQuality;
                    highestSnowBallValue = snowBallValue;
                }

            }
            Console.WriteLine($"{highestSnoballSnow} : {highestSnowBallTime} = {highestSnowBallValue} ({highestSnowBallQuality})");

        }
    }
}