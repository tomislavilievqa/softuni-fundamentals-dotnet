using System;
using System.Linq;
namespace _4._Morse_Code_Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] morseCode = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            

            string translatedMorseCode = string.Empty;

            for (int i = 0; i < morseCode.Length; i++)
            {
                string currentCodeLetter = morseCode[i];
                char letter = CurrChar(currentCodeLetter);
                translatedMorseCode += letter;
                                
            }
            Console.WriteLine(translatedMorseCode.ToUpper());
        }

        public static char CurrChar(string currentCodeLetter)
        {
            char currentLetter = '\0';

            if (currentCodeLetter.Equals(".-"))
            {
                 currentLetter = 'a';
            }
            else if (currentCodeLetter.Equals("-..."))
            {
                currentLetter = 'b';
            }
            else if (currentCodeLetter.Equals("-.-."))
            {
                currentLetter = 'c';
            }
            else if (currentCodeLetter.Equals("-.."))
            {
                currentLetter = 'd';
            }
            else if (currentCodeLetter.Equals("."))
            {
                currentLetter = 'e';
            }
            else if (currentCodeLetter.Equals("..-."))
            {
                currentLetter = 'f';
            }
            else if (currentCodeLetter.Equals("--."))
            {
                currentLetter = 'g';
            }
            else if (currentCodeLetter.Equals("...."))
            {
                currentLetter = 'h';
            }
            else if (currentCodeLetter.Equals(".."))
            {
                currentLetter = 'i';
            }
            else if (currentCodeLetter.Equals(".---"))
            {
                currentLetter = 'j';
            }
            else if (currentCodeLetter.Equals("-.-"))
            {
                currentLetter = 'k';
            }
            else if (currentCodeLetter.Equals(".-.."))
            {
                currentLetter = 'l';
            }
            else if (currentCodeLetter.Equals("--"))
            {
                currentLetter = 'm';
            }
            else if (currentCodeLetter.Equals("-."))
            {
                currentLetter = 'n';
            }
            else if (currentCodeLetter.Equals("---"))
            {
                currentLetter = 'o';
            }
            else if (currentCodeLetter.Equals(".--."))
            {
                currentLetter = 'p';
            }
            else if (currentCodeLetter.Equals("--.-"))
            {
                currentLetter = 'q';
            }
            else if (currentCodeLetter.Equals(".-."))
            {
                currentLetter = 'r';
            }
            else if (currentCodeLetter.Equals("..."))
            {
                currentLetter = 's';
            }
            else if (currentCodeLetter.Equals("-"))
            {
                currentLetter = 't';
            }
            else if (currentCodeLetter.Equals("..-"))
            {
                currentLetter = 'u';
            }
            else if (currentCodeLetter.Equals("...-"))
            {
                currentLetter = 'v';
            }
            else if (currentCodeLetter.Equals(".--"))
            {
                currentLetter = 'w';
            }
            else if (currentCodeLetter.Equals("-..-"))
            {
                currentLetter = 'x';
            }
            else if (currentCodeLetter.Equals("-.--"))
            {
                currentLetter = 'y';
            }
            else if (currentCodeLetter.Equals("--.."))
            {
                currentLetter = 'z';

            }
            else
            {
                currentLetter = ' ';
            }
            return currentLetter;
        }

    }
}