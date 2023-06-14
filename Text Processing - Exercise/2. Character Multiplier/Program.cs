using System;
using System.Linq;

namespace _2._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                string[] strings = Console.ReadLine().Split();

                string firstStr = strings[0];
                string secondStr = strings[1];

                string maxStr = string.Empty;
                string minStr = string.Empty;

                int totalSum = 0;

                if (firstStr.Length > secondStr.Length)
                {
                    maxStr = firstStr;
                    minStr = secondStr;
                }
                else
                {
                    maxStr = secondStr;
                    minStr = firstStr;
                }

                for (int i = 0; i < minStr.Length; i++)
                {
                    totalSum += firstStr[i] * secondStr[i];

                }
                string remainedString = maxStr.Substring(minStr.Length);

                for (int i = 0; i < remainedString.Length; i++)
                {
                    totalSum += remainedString[i];
                }

                Console.WriteLine(totalSum);
            }
        }
    }
}