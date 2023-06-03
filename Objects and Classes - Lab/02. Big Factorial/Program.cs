using System;
using System.Numerics;

namespace _3._Big_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = 2; i <= input; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);


        }
    }
}