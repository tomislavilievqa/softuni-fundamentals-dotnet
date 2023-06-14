using System;
using System.Reflection;

namespace _2._Vowels_Count
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    string input = Console.ReadLine();
            
        //    Console.WriteLine(VowelsCounter(input));
        //}
        //static string VowelsCounter(string input)
        //{
            
        //    input = input.ToLower();
        //    int amountOfAllSymbols = input.Length;
        //    int vowelsIntCounter = 0;
        //    string vowelsCounter = "";

        //    for (int i = 0; i < amountOfAllSymbols; i++)
        //    {
        //        //a, e, i, o, and u
        //        char curChar = input[i];
        //        if (curChar == 'a' || curChar == 'e' || curChar == 'u' || curChar == 'i' || curChar == 'o')
        //        {
        //            vowelsIntCounter++;
        //        }             
        //    }
        //    vowelsCounter = Convert.ToString(vowelsIntCounter);
        //    return vowelsCounter;
                   
        //}
        //МОЕТО РЕШЕНИЕ!
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            int result = GetVowelsCount(word);

            Console.WriteLine(result);
        }

        private static int GetVowelsCount(string word)
        {
            string vowels = "oiaue";
            int counter = 0;
            for (int i = 0; i < word.Length; i++)
            {
                string curSymbol = word[i].ToString();
                if (vowels.Contains(curSymbol));
                {
                    counter++;
                }
            }
            return counter;
        }

    }
}