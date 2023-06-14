using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists___Exercises
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            List<int> numberOfPassengersInWagon = Console.ReadLine().
                                  Split().
                                  Select(int.Parse).
                                  ToList();
            int maxCapacityOfWagon = int.Parse(Console.ReadLine());
            string input = "";

            while ((input = Console.ReadLine()) != "end")
            {
                string[] splitedInput = input.Split(" ");


                if (splitedInput.Length == 1)
                {
                    int passengers = int.Parse(splitedInput[0]);

                    for (int index = 0; index < numberOfPassengersInWagon.Count; index++)
                    {

                        if (numberOfPassengersInWagon[index] + passengers <= maxCapacityOfWagon)
                        {
                            numberOfPassengersInWagon[index] += passengers;
                            break;
                        }

                    }
                }
                else
                {
                    int passengers = int.Parse(splitedInput[1]);
                    numberOfPassengersInWagon.Add(passengers);
                }

            }
            Console.WriteLine(String.Join(" ", numberOfPassengersInWagon));
        }
    }
}
