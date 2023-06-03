using System;
using System.Linq;

namespace _6._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int current = 0;
            bool isEqual = false;
            for (int index = 0; index < arr.Length; index++)
            {
                
                int rightSum = 0;
               
                for (int i = index+1; i < arr.Length; i++)
                {
                    rightSum += arr[i];
                }
                int leftSum = 0;
                for (int i = index-1; i >= 0; i--)
                {
                    leftSum += arr[i];
                }

                if (leftSum == rightSum)
                {
                    isEqual = true;
                }
                if (isEqual)
                {
                    Console.WriteLine(index);
                    break;
                }

            }
            if (isEqual == false)
            {
                Console.WriteLine("no");
            }
           



        }
    }
}
