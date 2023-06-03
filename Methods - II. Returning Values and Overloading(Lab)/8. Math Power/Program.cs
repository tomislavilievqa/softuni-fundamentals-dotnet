using System;
using System.ComponentModel.Design;

namespace _8._Math_Power
{
    internal class Program
    {
        static double Power(double number, double power)
        {
            
            double result = Math.Pow(number, power);
            return result;

        }
        static void Main(string[] args)
        {
            double number = Math.Abs(double.Parse(Console.ReadLine()));
            double power = Math.Abs(double.Parse(Console.ReadLine()));

            Console.WriteLine(Power(number, power));
        }
    }
}