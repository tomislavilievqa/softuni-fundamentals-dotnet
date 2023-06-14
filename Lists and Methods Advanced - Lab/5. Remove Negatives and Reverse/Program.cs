using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _5._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().
                                Split().
                                Select(int.Parse).
                                ToList();
            
            List<int> positiveNumbers = new List<int>();
            int counter = 0;
            for (int index = 0; index < numbers.Count; index++)
            {

                if (numbers[index] > 0)
                {
                    positiveNumbers.Add(numbers[index]);                  
                    counter++;
                }
                
            }
            if (counter == 0)
            {
                Console.WriteLine("empty");
                return;
            }
            positiveNumbers.Reverse();
            Console.WriteLine(string.Join(" ", positiveNumbers));

        }
    }
}