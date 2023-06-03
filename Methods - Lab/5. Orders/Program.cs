using System;

namespace _5._Orders
{
    class Program
    {
        static void PrintTotal(string name, int quantity)
        {
            
            double sumTotal = 0;
            if (name == "coffee")
            {
                sumTotal = quantity * 1.50;
                Console.WriteLine($"{sumTotal:F2}");
            }
            else if (name == "water")
            {
                sumTotal = quantity * 1.00;
                Console.WriteLine($"{sumTotal:F2}");
            }
            else if (name == "coke")
            {
                sumTotal = quantity * 1.40;
                Console.WriteLine($"{sumTotal:F2}");
            }
            else if (name == "snacks")
            {
                sumTotal = quantity * 2.00;
                Console.WriteLine($"{sumTotal:F2}");
            }
        }
        static void Main(string[] args)
        {
            string orderName = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            
            PrintTotal(orderName,quantity);

        }
    }
}
