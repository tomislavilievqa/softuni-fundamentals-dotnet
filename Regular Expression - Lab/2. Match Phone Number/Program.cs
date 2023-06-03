﻿using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"( ?\+359 2 \d{3} \d{4}\b)|(\+ ?359-2-\d{3}-\d{4}\b)";
            var phones = Console.ReadLine();

            var phoneMatches = Regex.Matches(phones, regex);

            var matchedPhones = phoneMatches.Cast<Match>()
                .Select(a => a.Value
                .Trim())
                .ToArray();



            Console.WriteLine(string.Join(", ",matchedPhones));


        }
    }
}
