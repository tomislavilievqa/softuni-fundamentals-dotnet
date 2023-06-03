using System;
using System.Linq;
namespace _7._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumOfFirstArrayNumbers = 0;           
            bool isEqual = false;

            for (int index = 0; index < firstArray.Length; index++)
            {
               
                if (firstArray[index] == secondArray[index])
                {
                    sumOfFirstArrayNumbers += firstArray[index];
                    isEqual = true;
                    continue;
                }
                else if (firstArray[index] != secondArray[index])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
                    isEqual = false;
                    break;
                }
            }

            if(isEqual)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sumOfFirstArrayNumbers}");
            }




        }
    }
}
