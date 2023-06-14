using System;
namespace _6._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textInput = Console.ReadLine();
           
            PrintMiddleCharacter(textInput);
            
        }
        static void PrintMiddleCharacter(string textInput)
        {
            var middleChar = '\0';
            var curChar1 = '\0';
            var curChar2 = '\0';
            if (textInput.Length % 2 == 0)
            {
                for (int i = 0; i <= textInput.Length / 2; i++)
                {
                    curChar2 = textInput[i];
                }
                for (int i = 0; i < textInput.Length / 2; i++)
                {
                    curChar1 = textInput[i];
                }
                Console.WriteLine(curChar1.ToString()+curChar2.ToString());
            }
            else
            {
                middleChar = textInput[textInput.Length / 2];
                Console.WriteLine(middleChar.ToString());
            }

          
        }
    } 
}