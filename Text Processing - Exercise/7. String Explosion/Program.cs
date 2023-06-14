using System;
using System.Linq;
using System.Globalization;

namespace _7._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] splittedInput = Console.ReadLine().Split('>').ToArray();

            string result = splittedInput[0];
            int remainingPower = 0;

            for (int i = 1; i < splittedInput.Length; i++)
            {
                result += '>';
                string currentString = splittedInput[i];
                char currentDigit = currentString[0];

                

                int power = int.Parse(currentDigit.ToString()) + remainingPower;

                if (power > currentString.Length)
                {
                    remainingPower = power - currentString.Length;
                }
                else
                {
                    result += currentString.Substring(power);
                }
            }
            Console.WriteLine(result);
        }

    }
}