using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data;

namespace Regex___Exercises
{
    public class WorkingWithGroups
    {
        static void Groups()
        {
            string pattern = @"\d";

            string text = "An explanation 65656 of your regex will 6565 be automatically generated as you type.";

            MatchCollection collection = Regex.Matches(text, pattern);

            foreach (Match digit in collection)
            {

                Console.WriteLine(digit.Value);

            }
        }
    }
}

        


