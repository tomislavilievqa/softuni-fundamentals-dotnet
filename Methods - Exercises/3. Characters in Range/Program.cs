using System;
namespace _3._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstInput = char.Parse(Console.ReadLine());
            var secondInput = char.Parse(Console.ReadLine());
            CharactersBetween(firstInput, secondInput);

        }

        static void CharactersBetween(char first, char second)
        {

            string check = "";
            if (first < second)
            {
                for (int i = first + 1; i < second; i++)
                {
                    first++;
                    check = first.ToString();
                    Console.Write(check + " ");
                }
            }
            else if (second < first)
            {
                for (int i = second + 1; i < first; i++)
                {
                    second++;
                    check = second.ToString();
                    Console.Write(check + " ");
                }
            }




        }
    }
}