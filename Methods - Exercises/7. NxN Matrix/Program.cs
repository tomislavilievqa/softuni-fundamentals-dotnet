using System;
namespace _7._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintMatrix(number);

        }
        static void PrintMatrix(int number)
        {
            for (int row = 0; row < number; row++)
            {
                for (int line = 0; line < number; line++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}