using System;
using System.Linq;
namespace _6._Even_and_Odd_Subtraction_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayAsString = Console.ReadLine()
                                            .Split()
                                            .ToArray();

            int[] numbersFromArray = new int[arrayAsString.Length];

            for (int index = 0; index < arrayAsString.Length; index++)
            {
                numbersFromArray[index] = int.Parse(arrayAsString[index]);
            }

            int sum = 0;

            for (int index = 0; index < numbersFromArray.Length; index++)
            {
                if (numbersFromArray[index] % 2 == 0)
                {
                    sum += numbersFromArray[index];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
