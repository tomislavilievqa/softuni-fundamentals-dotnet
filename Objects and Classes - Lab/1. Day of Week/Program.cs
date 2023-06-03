﻿using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
namespace _1._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateAsText = Console.ReadLine();

            DateTime date = DateTime.ParseExact(dateAsText, "d-M-yyyy",
                CultureInfo.InvariantCulture);
            
            Console.WriteLine(date.DayOfWeek);
            
        }
    }
}
