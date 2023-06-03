using System;
using System.Linq;

namespace _9._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            byte lengthOfSequences = byte.Parse(Console.ReadLine()); // The first line holds the length of the sequences – integer in the range [1…100].
           
            int[] currentDNA = Console.ReadLine()
                                      .Split("!", StringSplitOptions.RemoveEmptyEntries)
                                      .Select(int.Parse)
                                      .ToArray();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Clone them!")
            {

                for (int i = 0; i < lengthOfSequences; i++)
                {
                    

                    int temp = currentDNA[i];
                    int counter = 0;
                    bool isEqual = false;
                    for (int next = i+1; i < lengthOfSequences; i++)
                    {
                        if (temp != currentDNA[next])
                        {
                            break;
                        }
                        else
                        {
                            counter++;
                            isEqual = true;
                            break;
                        }
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
