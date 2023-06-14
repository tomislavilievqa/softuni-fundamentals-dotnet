using System;
using System.Linq;
using System.Globalization;
using System.Collections;
using System.Text;

namespace _2._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                int currLen = words[i].Length;
                
                for (int j = 0; j < currLen; j++)
                {
                    result = result.Append(words[i]);
                }

            }
            Console.WriteLine(result);
        }
    }
}