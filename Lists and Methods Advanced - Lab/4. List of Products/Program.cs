using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _4._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();


            for (int index = 0; index < lines; index++)
            {
                string line = Console.ReadLine();
                products.Add(line);

            }
            products.Sort();

            int number = 1;
            for (int i = 0; i < products.Count; i++)
            {
                string currProduct = number.ToString() + "." + products[i];
                Console.WriteLine(currProduct);
                number++;

            }






        }
    }
}