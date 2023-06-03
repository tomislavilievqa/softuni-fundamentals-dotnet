using System;
using System.Linq;
namespace _8._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int finalSum = 0;
            if (elements.Length == 1)
            {
                Console.WriteLine(elements[0]);
                return;
            }
            while (elements.Length > 1)
            {
               
                int[] temp = new int[elements.Length - 1];
              for (int index = 0; index < temp.Length; index++)
              {
                    temp[index] = elements[index] + elements[index + 1];
                    finalSum = temp[index];
                    

                }
              elements = temp;
            }
                Console.WriteLine(finalSum);

        }
    }
}
