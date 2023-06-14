using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            int iterationsNum = int.Parse(Console.ReadLine());
            Random random = new Random();
            
            for (int i = 0; i < iterationsNum; i++)
            {
                // they can be with var or array :)

                phrases[i] = phrases[random.Next(0, phrases.Length)];
                events[i] = events[random.Next(0, events.Length)];
                cities[i] = cities[random.Next(0, cities.Length)];
                var currAuthor = authors[random.Next(0, authors.Length)];

                
                Console.WriteLine($"{phrases[i]} {events[i]} {currAuthor} – {cities[i]}");

            }



        }
    }
}