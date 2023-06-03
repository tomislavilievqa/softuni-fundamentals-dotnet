using System;

namespace _2._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // броя места, които ще заемем в масива
            int[] numbers = new int[n];
            // създаваме масив, който има брой места, колкото в N

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                // запазваме в масива на конкрентните позиции стойностите, които получаваме от конзолата
            }
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
                Console.WriteLine();

            }

        }
    }
}
