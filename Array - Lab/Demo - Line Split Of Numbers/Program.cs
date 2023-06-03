using System;
using System.Linq;
namespace Demo___Line_Split_Of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            string[] numbersToText = line.Split();
            //масив който разделя числата на редове

            int[] numbers = new int[numbersToText.Length];
            // нов масив,в който ще запазваме текста като целочислено число. Правим го с дължината на предишния масив

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(numbersToText[i]);
            }

            //Втори вариант

            int[] nums = Console.
                ReadLine(). // прочети ми реда от конзолата
                Split(). // сплитни го в различни редове
                Select(int.Parse). // парсни ми числата в инт
                ToArray(); // направи ми го в масив

            // така вече сме сложили разделени числата в масива

            
        }

    }
}
