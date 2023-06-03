using System;
using System.Linq;
namespace _3._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double[] numbers = Console
                .ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            
            int[] roundedNums = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                roundedNums[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);

                Console.WriteLine($"{numbers[i]} => {roundedNums[i]}");
            }
            

        }
    }
}
