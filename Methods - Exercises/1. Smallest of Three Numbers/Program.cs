using System;
using System.Runtime.ExceptionServices;

namespace _1._Smallest_of_Three_Numbers
{
    internal class Program
    {

        //static double SmallestNumber(double input1, double input2, double input3)
        //{

        //    double smallestFromFirstTwo = 0d;
        //    double smallestNum = 0d; 
        //    smallestFromFirstTwo = Math.Min(input1, input2);

        //    if (smallestFromFirstTwo > input3)
        //    {
        //         smallestNum = input3;
        //    }else if (smallestFromFirstTwo < input3)
        //    {
        //        smallestNum = smallestFromFirstTwo;
        //    }
        //    return smallestNum;

        //}
        //Моето решение! Моят метод
        //private static int SmallestNumber(int[] numbers)
        //{


        //}
        //static void Main(string[] args)
        //{
        //    double input1 = Math.Abs(double.Parse(Console.ReadLine()));
        //    double input2 = Math.Abs(double.Parse(Console.ReadLine()));
        //    double input3 = Math.Abs(double.Parse(Console.ReadLine()));

        //    Console.Write(SmallestNumber(input1, input2, input3));
        //}

        //private static int SmallestNumber(int[] numbers)
        //{
        //    int result = int.MaxValue;
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        result = SmallerNumber(numbers[i], result);
        //    }
        //    return result;

        //}
        static int SmallerNumber(int first, int second)
        {
            if (first > second)
            {
                return second;
            }
            return first;
        }
        static void Main(string[] args)
        {
            int result = int.Parse(Console.ReadLine());

            for (int i = 0; i < 2; i++)
            {
                int number = int.Parse(Console.ReadLine());
                result = SmallerNumber(result, number);
            }
            
            Console.Write(result);
        }
    }
}