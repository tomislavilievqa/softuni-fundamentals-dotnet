using System;
namespace _9._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string input = Console.ReadLine();
            while (input != "END")
            {
                int inputInt = int.Parse(input);
                bool isPalindrome = IsPalindrome(inputInt);
                if (isPalindrome)
                {
                    Console.WriteLine("true");
                }
                else if (!isPalindrome)
                {
                    Console.WriteLine("false");
                }


                input = Console.ReadLine();
            }
        }
        static bool IsPalindrome(int inputInt)
        {
            string numbers = inputInt.ToString();
            string forwardOrder = string.Empty;
            string backwardOrder = string.Empty;
            for (int i = 0; i < numbers.Length; i++)
            {
                forwardOrder += numbers[i];
            }
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                backwardOrder += numbers[i];
            }

            if (forwardOrder == backwardOrder)
            {

                return true;
                //Console.WriteLine("true");
            }
            else
            {
                return false;
                //Console.WriteLine("false");
            }
        }

    }
}