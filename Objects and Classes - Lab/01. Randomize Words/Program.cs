using System;
namespace _2._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Random random = new Random(1000); // вместо да ползваш текущото време, ползвай това число от което да тръгне формулата

            //Console.WriteLine(random.Next(2, 7)); // чрез .Next метода, който е част от нон-статик класа Random, всеки път ще получаваме различно число от зададен диапазон


            string[] words = Console.ReadLine().Split(" ");

            var random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                var randomIndex = random.Next(0, words.Length);

                var randomEl = words[randomIndex];
                var element = words[i];

                words[randomIndex] = element;
                words[i] = randomEl;

            }

            Console.WriteLine(string.Join(Environment.NewLine, words));

        }
    }
}