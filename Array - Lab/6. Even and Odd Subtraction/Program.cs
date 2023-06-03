using System;
using System.Linq;
namespace _6._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbersAsText = Console.ReadLine()
                                            .Split()
                                            .ToArray();
            
            int[] numbers = new int[numbersAsText.Length];

            for (int index = 0; index < numbersAsText.Length; index++)
            {
                numbers[index] = int.Parse(numbersAsText[index]);

            }
            int evenNumbersSum = 0;
            int oddNumbersSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbersSum += numbers[i];
                }
                else
                {
                    oddNumbersSum += numbers[i];
                }
            }

            int finalResult = evenNumbersSum - oddNumbersSum;

            Console.WriteLine(finalResult);

        }
    }
}
