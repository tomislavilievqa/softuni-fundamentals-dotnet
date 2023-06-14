using System;
namespace _8._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            double volume = 0;
            double biggestKeg = double.MinValue;
            string biggestBeer = string.Empty;
        
            for (int i = 1; i <= n; i++)
            {
              
                String modelBeer = Console.ReadLine();
                var radius = double.Parse(Console.ReadLine());
                var height = int.Parse(Console.ReadLine());

                volume = Math.PI * (radius * radius) * (double)height;
               
                if (volume > biggestKeg)
                {
                    biggestKeg = volume;
                    biggestBeer = modelBeer;
                    
                }
     
            }
            Console.WriteLine(biggestBeer);
           
        }
    }
}