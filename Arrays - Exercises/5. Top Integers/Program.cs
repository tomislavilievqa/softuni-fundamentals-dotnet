using System;
using System.Linq;

namespace _5._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine() // 1 4 3 2
                .Split()
                .Select(int.Parse)
                .ToArray();


            string result = "";
            for (int index = 0; index < numbers.Length; index++)
            {
                int current = numbers[index];
                bool isTopInt = true;
               
                for (int i = index+1; i < numbers.Length; i++)
                {
                    if (current <= numbers[i])
                    {
                        isTopInt = false;
                        break;
                    }        
                }
                if (isTopInt)
                {
                    result += current + " "; 
                }
            }
            Console.WriteLine(result);
            

            //1 2 3 4 5
            //1
            // 2 3 4 5
            //2
            // 3 4 5
            //Console.WriteLine(String.Join(" ", collection));
        }
    }
}
