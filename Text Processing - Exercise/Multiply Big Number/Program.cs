using System;
using System.Text;
using System.Linq;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string numberInString = Console.ReadLine();

            
            int multiplier = int.Parse(Console.ReadLine());

            StringBuilder builder = new StringBuilder();

            int onMind = 0;

            for (int i = numberInString.Length - 1; i >= 0; i--)
            {
                int lastDig = int.Parse(numberInString[i].ToString());

                int result = lastDig * multiplier + onMind;

                builder.Append(result % 10);

                onMind = result / 10;           
            }
            if (onMind != 0)
            {
                builder.Append(onMind);
            }

            string resultNumber = string.Join("", builder.ToString()
                .Reverse())
                .TrimStart('0');

            if (resultNumber == string.Empty)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(resultNumber);
            }
            
        }
    }
}