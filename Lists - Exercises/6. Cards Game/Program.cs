using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace _6._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<int> cardsOfplayer1 = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToList();

            List<int> cardsOfplayer2 = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToList();

            int itterationsCount = cardsOfplayer1.Count*2;

            List<int> cards = new List<int>();

 
            while (true)
            {
                if (cardsOfplayer1[0] > cardsOfplayer2[0])
                {
                    int winningCard = cardsOfplayer1[0];
                    cardsOfplayer1.Add(winningCard);
                    cardsOfplayer1.Add(cardsOfplayer2[0]);
                }
                else if(cardsOfplayer1[0] < cardsOfplayer2[0])
                {
                    int winningCard = cardsOfplayer2[0];
                    cardsOfplayer2.Add(winningCard);
                    cardsOfplayer2.Add(cardsOfplayer1[0]);
                }

                cardsOfplayer1.Remove(cardsOfplayer1[0]);
                cardsOfplayer2.Remove(cardsOfplayer2[0]);

                if (cardsOfplayer1.Count == 0)
                {
                    int sum = cardsOfplayer2.Sum();
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                    break;
                }
                else if (cardsOfplayer2.Count == 0)
                {
                    int sum = cardsOfplayer1.Sum();
                    Console.WriteLine($"First player wins! Sum: {sum}");
                    break;
                }
            }
        }
    }
}