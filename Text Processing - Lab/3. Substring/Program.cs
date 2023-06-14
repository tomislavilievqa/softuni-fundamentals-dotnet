using System;
using System.Linq;
using System.Globalization;
using System.Collections;
using System.Text;

namespace _3._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();
            int index = text.IndexOf(key);

            while (index != -1)
            {
                text = text.Remove(index, key.Length);

                index = text.IndexOf(key);

            }
            Console.WriteLine(text);

        }
    }
}