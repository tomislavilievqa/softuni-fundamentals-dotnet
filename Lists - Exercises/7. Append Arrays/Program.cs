using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace _7._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 2 3 | 4 5 6 | 7  8
            string[] numbers = Console.ReadLine().Split("|").ToArray();

            List<string> result = new List<string>();

            for (int index = numbers.Length - 1; index >= 0; index--)
            {
                string[] currentNumbers = numbers[index].Split(new[] { ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < currentNumbers.Length; j++)
                {
                    result.Add(currentNumbers[j]);
                }

            }
            Console.Write(String.Join(" ", result));


        }
    }
}