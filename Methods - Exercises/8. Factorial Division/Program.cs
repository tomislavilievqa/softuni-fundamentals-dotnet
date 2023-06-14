using System;
using System.Security.AccessControl;
using System.Security.Cryptography;

namespace _8._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = Math.Abs(double.Parse(Console.ReadLine()));
            double secondNum = Math.Abs(double.Parse(Console.ReadLine()));
            
            double result = CalculateFactorial(firstNum) / CalculateFactorial(secondNum);
            Console.WriteLine($"{result:F2}");
        }
        static double CalculateFactorial(double number)
        {
            double result = 1d;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}