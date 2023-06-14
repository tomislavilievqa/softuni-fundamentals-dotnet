using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            List<int> result = new List<int>();
            

            for (int i = 0; i < Math.Max(firstList.Count, secondList.Count); i++)
            {
                if (firstList.Count > i)
                {
                    result.Add(firstList[i]);
                }
                if (secondList.Count > i)
                {
                    result.Add(secondList[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));

        }
    }
}