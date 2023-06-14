using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().
                                Split().
                                Select(int.Parse).
                                ToList();   
            
            while (true)
            {
                List<string> commands = Console.ReadLine().
                                  Split().
                                  ToList();
                
                if (commands[0] == "Add")
                {
                    
                    numbers.Add(int.Parse(commands[1]));
                }
                if (commands[0] == "Remove")
                {
                    numbers.Remove(int.Parse(commands[1]));
                    //numbers.RemoveAt(addedNumber);
                }
                if (commands[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(commands[1]));
                }
                if (commands[0] == "Insert")
                {
                    int numberToInsert = int.Parse(commands[1]);
                    int indexToInsert = int.Parse(commands[2]);
                    numbers.Insert(indexToInsert, numberToInsert);
                }
                
                if (commands.Contains("end"))
                {
                    break;
                }
            }
            
            Console.WriteLine(String.Join(" ",numbers));

            
        }
    }
}