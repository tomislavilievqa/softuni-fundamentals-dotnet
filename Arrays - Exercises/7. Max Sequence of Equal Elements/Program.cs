using System;
using System.Linq;

namespace _7._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] numbers = Console.ReadLine().Split();//.Select(int.Parse).ToArray();

            int bestCounter = 0;
            int bestIndex = 0;
            string bestResult = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                string temp = numbers[i];
                int counter = 1;
                string result = string.Empty;                
                for (int index = i + 1; index < numbers.Length; index++)
                {
                    if (numbers[i] == numbers[index])
                    {
                        counter++;
                        temp += " " + numbers[index];
                    }
                    else
                    {
                        break;
                    }
                }
                if (bestCounter < counter)
                {
                    bestCounter = counter;
                    bestIndex = i;
                    bestResult = temp;                   
                }
                
                //else if (bestCounter > counter)
                //{
                //    break;
                //}
                
            }
            Console.WriteLine(String.Join(" ",bestResult));
        }
    }
}
