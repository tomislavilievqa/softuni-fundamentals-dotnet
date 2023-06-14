using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            int input3 = int.Parse(Console.ReadLine());
           
            Console.WriteLine(Substact(input1, input2, input3));
        }

        static int Sum(int input1, int input2)
        {
            int sum = input1 + input2;
            
            return sum;
        }
        static int Substact(int input1, int input2, int input3)
        {
            int substact = Sum(input1, input2) - input3;
            
            return substact;
        }
    }
}