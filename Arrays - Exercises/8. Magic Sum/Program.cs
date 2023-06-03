using System;
using System.Linq;

namespace _8._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int magicNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];
                int result = 0;

                for (int nextNum = i + 1; nextNum < numbers.Length; nextNum++)
                {
                    result = currentNum + numbers[nextNum];
                    if (result == magicNum)
                    {
                        Console.WriteLine($"{currentNum.ToString()} {numbers[nextNum].ToString()}");
                        break;
                    }

                }

            }

        }
    }
}
