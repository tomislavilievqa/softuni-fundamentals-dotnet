using System;
using System.Linq;
namespace _6._Even_and_Odd_Subtraction_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();

            int evenNumbersSum = 0;
            int oddNumbersSum = 0;

            for (int index = 0; index < elements.Length; index++)
            {
                if (elements[index] % 2 == 0)
                {
                    evenNumbersSum += elements[index];
                }
                else
                {
                    oddNumbersSum += elements[index];
                }
            }

            int finalResult = evenNumbersSum - oddNumbersSum;

            Console.WriteLine(finalResult);
        }
    }

    
}


