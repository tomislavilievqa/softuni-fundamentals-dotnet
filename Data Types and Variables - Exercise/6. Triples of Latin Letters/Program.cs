
using System;
namespace _6._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
       
          
            for (int j = 0; j < n; j++)
            {
                char first = (char)('a' + j);
                
                for (int i = 0; i < n; i++)
                {
                    char second = (char)('a' + i);
                    
                    for (int k = 0; k < n; k++)
                    {
                        char third = (char)('a' + k);


                        Console.WriteLine($"{first }{second }{ third}");
                    }
                }
            }
            
            
            
        }
    }
}