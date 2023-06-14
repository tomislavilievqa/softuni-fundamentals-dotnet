using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
namespace _7._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> listForManipulations = Console.ReadLine().
                               Split().
                               Select(int.Parse).
                               ToList();
            List<int> filteredNumbers = new List<int>();
            bool changesIsmade = false;
            while (true)
            {
                List<string> commands = Console.ReadLine().
                                  Split().
                                  ToList();

                if (commands[0].Contains("end"))
                {
                    break;
                }
                if (commands[0].Contains("Contains"))
                {
                    if (doContains(listForManipulations, commands))
                    {
                        Console.WriteLine("Yes");
                    }
                    else if (!doContains(listForManipulations, commands))
                    {
                        Console.WriteLine("No such number");
                    }
                }
                if (commands[0].Contains("PrintOdd"))
                {
                    PrintOddNumbers(listForManipulations, commands);
                }
                if (commands[0].Contains("PrintEven"))
                {
                    PrintEvenNumbers(listForManipulations, commands);
                }
                if (commands[0].Contains("GetSum"))
                {
                    GetSum(listForManipulations);
                }
                if (commands[0].Contains("Filter"))
                {
                    Filter(listForManipulations, commands);
                }
                if (commands[0] == "Add")
                {
                    changesIsmade = true;
                    listForManipulations.Add(int.Parse(commands[1]));
                }
                if (commands[0] == "Remove")
                {
                    changesIsmade = true;
                    listForManipulations.Remove(int.Parse(commands[1]));
                    //numbers.RemoveAt(addedNumber);
                }
                if (commands[0] == "RemoveAt")
                {
                    changesIsmade = true;
                    listForManipulations.RemoveAt(int.Parse(commands[1]));
                }
                if (commands[0] == "Insert")
                {
                    changesIsmade= true;
                    int numberToInsert = int.Parse(commands[1]);
                    int indexToInsert = int.Parse(commands[2]);
                    listForManipulations.Insert(indexToInsert, numberToInsert);
                }

            }
            if (changesIsmade)
            {
                Console.WriteLine(string.Join(" ", listForManipulations));
            }

            bool doContains(List<int> numbers, List<string> commands)
            {
                bool doContains = true;
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == int.Parse(commands[1]))
                    {
                        return true;

                    }
                }
                return false;
            }
            static void PrintOddNumbers(List<int> listForManipulations, List<string> commands)
            {

                List<int> oddNumbers = new List<int>();
                for (int i = 0; i < listForManipulations.Count; i++)
                {

                    if (listForManipulations[i] % 2 != 0)
                    {
                        oddNumbers.Add(listForManipulations[i]);
                    }

                }

                Console.WriteLine(string.Join(" ", oddNumbers));

            }
            static void PrintEvenNumbers(List<int> manipulativeList, List<string> commands)
            {
                List<int> evenNumbers = new List<int>();

                for (int i = 0; i < manipulativeList.Count; i++)
                {
                    if (commands[0] == "PrintEven")
                    {
                        if (manipulativeList[i] % 2 == 0)
                        {
                            evenNumbers.Add(manipulativeList[i]);
                        }
                    }

                }
                Console.WriteLine(string.Join(" ", evenNumbers));

            }
            static void GetSum(List<int> numbers)
            {
                int sum = 0;
                for (int i = 0; i < numbers.Count; i++)
                {
                    sum += numbers[i];
                }

                Console.WriteLine(sum);
            }
            static void Filter(List<int> listForManipulations, List<string> commands)
            {
                List<int> filteredNumbers = new List<int>();
                for (int i = 0; i < listForManipulations.Count; i++)
                {
                    switch (commands[1])
                    {
                        case "<":
                            if (listForManipulations[i] < int.Parse(commands[2]))
                            {
                                filteredNumbers.Add(listForManipulations[i]);

                            }
                            break;
                        case ">":
                            if (listForManipulations[i] > int.Parse(commands[2]))
                            {
                                filteredNumbers.Add(listForManipulations[i]);

                            }
                            break;
                        case "<=":
                            if (listForManipulations[i] <= int.Parse(commands[2]))
                            {
                                filteredNumbers.Add(listForManipulations[i]);

                            }
                            break;
                        case ">=":
                            if (listForManipulations[i] >= int.Parse(commands[2]))
                            {
                                filteredNumbers.Add(listForManipulations[i]);

                            }
                            break;

                    }

                }
                Console.WriteLine(String.Join(" ", filteredNumbers));
            }
        }
    }
}
