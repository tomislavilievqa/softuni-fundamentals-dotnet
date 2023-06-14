using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace _4._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listForManipulation = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = string.Empty;
            bool isInvalidIndex = false;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] commands = input.Split().ToArray();


                if (commands.Length == 2)
                {
                    switch (commands[0])
                    {
                        case "Add":
                            int givenNumber = int.Parse(commands[1]);
                            listForManipulation.Add(givenNumber);
                            break;
                        case "Remove":
                            int index = int.Parse(commands[1]);
                            if (index < 0 || index >= listForManipulation.Count)
                            {
                                Console.WriteLine("Invalid index");
                                break;
                            }                          
                            listForManipulation.RemoveAt(index);
                            break;
                    }
                }
                if (commands.Length == 3)
                {
                    switch (commands[0])
                    {
                        case "Insert":
                            int index = int.Parse(commands[2]);
                            if (index < 0 || index >= listForManipulation.Count)
                            {
                                Console.WriteLine("Invalid index");
                                break;
                            }                         
                            int givenNumber = int.Parse(commands[1]);
                            listForManipulation.Insert(index, givenNumber);
                            break;

                        case "Shift":
                            if (commands[1] == "right")
                            {
                                int count = int.Parse(commands[2]);
                                for (int i = 0; i < count; i++)
                                {
                                    listForManipulation.Insert(0, listForManipulation[listForManipulation.Count-1]);
                                    listForManipulation.RemoveAt(listForManipulation.Count - 1);
                                }
                            }
                            else if (commands[1] == "left")
                            {
                                int count = int.Parse(commands[2]);
                                for (int i = 0; i < count; i++)
                                {
                                    listForManipulation.Add(listForManipulation[0]);
                                    listForManipulation.RemoveAt(0);
                                }
                            }
                            break;
                    }
                }
            }
            Console.WriteLine(String.Join(" ", listForManipulation));
        }

        //static int Remove(List<int> num, )
    }
}