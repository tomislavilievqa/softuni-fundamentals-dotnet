using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.ExceptionServices;

namespace _6.__Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string originalText = Console.ReadLine();

            for (int i = 0; i < originalText.Length - 1; i++)
            {
                char letter = originalText[i];

                char nextChar = originalText[i + 1];

                if (letter == nextChar)
                {
                    originalText = originalText.Remove(i, 1);
                    i = -1;
                }
            }

            Console.WriteLine(originalText);.

        }
    }
}