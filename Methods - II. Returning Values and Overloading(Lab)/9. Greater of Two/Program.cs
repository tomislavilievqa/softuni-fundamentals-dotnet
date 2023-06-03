using System;

namespace _9._Greater_of_Two
{
    internal class Program
    {
        static int GetMax(int x, int y) 
        {
            int result = 0;          
            if (x > y)
            {
                result = x;               
            }else if (y > x)
            {
                result = y;        
            }
            return result;
        }
        static char GetMax(char x, char y)
        {
            char result = '\0';
            
            if (x > y)
            {
                result = x;
                
            }
            else if (y > x)
            {
                result = y;              
            }
            return result;
        }
        static string GetMax(string x, string y)
        {
            string result = Convert.ToChar(x);
            
            if (x > y)
            {
                return x;
            }
            else if (y > x)
            {
                
            }
            
            return result;
        }

        static void Main(string[] args)
        {
            string typeOfVariable = Console.ReadLine();

            if (typeOfVariable == "int")
            {
                int firstInput = int.Parse(Console.ReadLine());
                int secondInput = int.Parse(Console.ReadLine());
                int result = GetMax(firstInput, secondInput);
            }
            else if(typeOfVariable == "char") 
            {
                char firstInput = char.Parse(Console.ReadLine());
                char secondInput = char.Parse(Console.ReadLine());              
                char result = GetMax(firstInput, secondInput);

            }
            else if(typeOfVariable== "string") 
            {
                string firstInput = Console.ReadLine();
                string secondInput = Console.ReadLine();
                string result = GetMax(firstInput, secondInput);
            }
            
            Console.WriteLine("Hello, World!");
        }
    }
}