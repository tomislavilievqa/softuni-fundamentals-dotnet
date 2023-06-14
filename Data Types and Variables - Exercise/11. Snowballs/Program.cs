using System;
using System.Numerics;
namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());
            BigInteger highestCalculatedSnowball = 0;
            BigInteger highestSnow = 0;
            BigInteger highestTime = 0;
            BigInteger highestQuality = 0;
            for (int i = 0; i < numberOfSnowballs; i++)
            {
                
                BigInteger snowballSnow = BigInteger.Parse(Console.ReadLine());
                BigInteger snowballTime = BigInteger.Parse(Console.ReadLine());
                BigInteger snowballQuality = BigInteger.Parse(Console.ReadLine());

                
                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime) , (int)snowballQuality);
                
                if (highestCalculatedSnowball < snowballValue)
                {
                    highestCalculatedSnowball = snowballValue;
                    highestSnow = snowballSnow;
                    highestTime = snowballTime;
                    highestQuality = snowballQuality;
                    
                }
                
            }
            Console.WriteLine($"{highestSnow} : {highestTime} = {highestCalculatedSnowball} ({highestQuality})");



        }
    }
}