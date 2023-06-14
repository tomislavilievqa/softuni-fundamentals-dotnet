using System;
using System.Runtime.InteropServices;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int pokedTargets = 0;
            double halfValue = (1.0 * pokePower) / 2;
           
            while (distance <= pokePower)
            {

                pokePower -= distance;
                pokedTargets++;
                if (pokePower == halfValue)
                {
                    if (exhaustionFactor != 0)
                    {
                        pokePower = pokePower / exhaustionFactor;
                    }
                    
                }

            }
            Console.WriteLine(pokePower);
            Console.WriteLine(pokedTargets);
        }
    }
}