using System;
using System.Linq;

namespace _2._Ascii_Sumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            string randomString = Console.ReadLine();

            int sum = 0;

            for (int i = firstChar + 1; i < secondChar; i++)
            {
                int indexOfInputChars = 0;
                char[] inputChars = new char[secondChar - firstChar];
                char currentChar = inputChars[indexOfInputChars];
                currentChar = Convert.ToChar(i);

                for (int j = 0; j < randomString.Length; j++)
                {
                    if (currentChar == randomString[j])
                    {
                        sum += currentChar;
                    }
                }
            }
            
            Console.WriteLine(sum);


        }
    }
}