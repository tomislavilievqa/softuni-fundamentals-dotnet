using System;
using System.Linq;

namespace _1._Extract_Person_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string inputSentence = Console.ReadLine();

                int startIndexOfName = inputSentence.IndexOf('@');
                int endIndexOfName = inputSentence.IndexOf('|');
                
                int startIndexOfAge = inputSentence.IndexOf('#');
                int endIndexOfAge = inputSentence.IndexOf('*');

                string age = inputSentence.Substring(startIndexOfAge+1, endIndexOfAge - startIndexOfAge - 1);
                string firstName = inputSentence.Substring(startIndexOfName+1, endIndexOfName - startIndexOfName - 1);

                Console.WriteLine($"{firstName} is {age} years old.");
            }




        }
    }
}