using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] names = Console.ReadLine().Split(", ").ToArray();
            bool isValidLength = false;
            bool isValid = false;

            for (int i = 0; i < names.Length; i++)
            {
                string currentUserName = names[i];

                if (currentUserName.Length < 3 || currentUserName.Length > 16)
                {
                    isValidLength = false;
                    continue;
                }
                else
                {
                    isValidLength = true;
                }

                char[] chars = currentUserName.ToCharArray();

                foreach (char currChar in chars)
                {
                    if (char.IsLetterOrDigit(currChar))
                    {
                        isValid = true;
                    }
                    else if(currChar == '-')
                    {
                        isValid = true;
                    }
                    else if (currChar == '_')
                    {
                        isValid = true;
                    }
                    else
                    {
                        isValid = false;
                        break;
                    }
                }
                if (isValid)
                {
                    Console.WriteLine(String.Join(" ",currentUserName));
                }
            }
        }
        
    }
}
