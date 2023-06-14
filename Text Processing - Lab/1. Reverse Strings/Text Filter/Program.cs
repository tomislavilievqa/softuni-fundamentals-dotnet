using System;
using System.Linq;
using System.Globalization;
using System.Collections;
using System.Text;
namespace _4._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ").ToArray();


            for (int i = 0; i < bannedWords.Length; i++)
            {
                string text = Console.ReadLine();
                text = text.Replace(bannedWords[i], '*'.ToString());

            }
        }
    }
}