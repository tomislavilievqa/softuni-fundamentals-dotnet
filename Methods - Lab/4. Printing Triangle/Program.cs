using System;

namespace _4._Printing_Triangle
{
    class Program
    {
        static void PrintLine(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write(col + " ");
            }

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            
            int number = int.Parse(Console.ReadLine());

            for (int row = 1; row <= number; row++)
            {
                PrintLine(row);
            }
            for (int row = number-1; row >= 1; row--)
            {

                PrintLine(row);

            }

        }
    }
}
