using System;
using System.Linq;

namespace _4._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] input = Console.ReadLine()
                .Split()
                .ToArray();

            for (int currenIndex = input.Length - 1; currenIndex >= 0; currenIndex--)
            {
                Console.Write(input[currenIndex] + " ");
            }

            Console.WriteLine();


        }
    }
}
