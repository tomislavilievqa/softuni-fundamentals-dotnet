using System;
using System.Linq;
namespace _1._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfWagons = int.Parse(Console.ReadLine());

            int[] train = new int[countOfWagons];

            for (int i = 0; i < countOfWagons; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(String.Join(" ", train));
            Console.WriteLine(train.Sum());



        }
    }
}
