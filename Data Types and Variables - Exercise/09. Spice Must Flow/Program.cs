using System;
namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int days = 0;
            int storage = 0;
            if(startingYield < 100) {
                
                Console.WriteLine(days);
                Console.WriteLine(storage);
            }
            else
            {
                while (startingYield >= 100)
                {
                    days++;
                    storage += startingYield - 26;
                    startingYield -= 10;
                   
                }
                storage -= 26;
                Console.WriteLine(days);
                Console.WriteLine(storage);
            }

           
        }
    }
}