using System;
using System.Text.RegularExpressions;

namespace Regex___Exercises

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\d";

            Regex regex = new Regex(pattern);

            string input = "An explanation 65656 of your regex will 6565 be automatically generated as you type.";

            MatchCollection collection = regex.Matches(input);

            // MatchCollection е колекция от matcho-ове == все едно имаме List<string>

            foreach (Match digit in collection)
            {
                
                Console.WriteLine(digit.Value);

            }


            // втори вариант само с клас Regex
            //string pattern = @"\d"; 

            //string input = "An explanation 65656 of your regex will 6565 be automatically generated as you type.";

            //MatchCollection collection = Regex.Matches(input,pattern);

            //foreach (Match digit in collection)
            //{

            //    Console.WriteLine(digit.Value);

            //}

        }
    }
}