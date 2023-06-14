using Microsoft.VisualBasic;
using System;
using System.Globalization;

namespace _1._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
           
            DateTime dayOfWeek = DateTime.ParseExact(date,"d-M-yyyy",CultureInfo.InvariantCulture);

            Console.WriteLine(dayOfWeek.DayOfWeek);

            
            
        }
    }
}