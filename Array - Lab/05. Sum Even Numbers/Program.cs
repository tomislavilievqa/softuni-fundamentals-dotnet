using System;
using System.Linq;
namespace _5._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] allNumbers = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int evenSum = 0;

            for (int i = 0; i < allNumbers.Length; i++)
            {
                if (allNumbers[i] % 2 == 0)
                {
                    evenSum += allNumbers[i];
                }

            }
            Console.WriteLine(evenSum);
         








        }
    }
}
