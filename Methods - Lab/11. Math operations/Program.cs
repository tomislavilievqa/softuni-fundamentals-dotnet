using System;
namespace _11._Math_operations
{
    internal class Program
    {
        static double Calculate(double a, string @operator, double b)
        {
            double result = 0d;
            if (@operator == "+")
            {
                result = a + b;
            }
            else if (@operator == "-")
            {
                result = a - b;
            }
            else if (@operator == "/")
            {
                result = a / b;
            }
            else if (@operator == "*")
            {
                result = a * b;
            }
            else
            {

            }
            return result;
        }

        static void Main(string[] args)
        {
            
            double firstNum = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double secondNum = double.Parse(Console.ReadLine());
            double result = Calculate(firstNum, @operator, secondNum);
            Console.WriteLine(result);

        }
    }
}