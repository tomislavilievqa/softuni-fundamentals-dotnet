using System;
using System.Linq;
using System.Globalization;
using System.Collections;
using System.Text;


namespace _5._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textInput = Console.ReadLine();

            string text = string.Empty;
            string numbers = string.Empty;
            string chars = string.Empty;

            for (int i = 0; i < textInput.Length; i++)
            {
                char curr = textInput[i];
                if (char.IsDigit(curr))
                {
                    numbers += curr;
                  
                }
                else if (char.IsLetter(curr))
                {
                    text += curr;
                }
                else
                {
                    chars += curr;
                }

            }
            Console.WriteLine($"{numbers}\n{text}\n{chars}");




        }


    }
}