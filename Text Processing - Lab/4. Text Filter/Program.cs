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
            string text = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {               

                text = text.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
                
            }

            Console.WriteLine(text);
        }
    }
}