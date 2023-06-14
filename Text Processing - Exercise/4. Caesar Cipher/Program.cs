using System;
using System.Linq;
using System.Collections.Generic;
namespace _4._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputText = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            
            List<char> encryptedText = new List<char>();

            char[] currentWord = new char[inputText.Length];

            for (int i = 0; i < inputText.Length; i++)
            {
                currentWord = inputText[i].ToCharArray();
                             
                for (int j = 0; j < currentWord.Length; j++)
                {
                    int shiftedChar = currentWord[j] + 3;
                    currentWord[j] = (char)shiftedChar;
                    encryptedText.Add(currentWord[j]);                  
                }
                if (i != inputText.Length - 1)
                {
                    encryptedText.Add('#');
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(String.Join("",encryptedText));




        }
        
    }
}