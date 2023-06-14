using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _3._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            List<string> guestlist = new List<string>();                     
            bool isAlreadyInTheList = false;
            bool isNotInTheList = false;

            for (int index = 0; index < numberOfCommands; index++)
            {
                List<string> commands = Console.ReadLine()
                                   .Split()
                                   .ToList();
                
                string nameOfGuest = commands[0];
                
                if (commands[2].Contains("going"))
                {                          
                    for (int i = 0; i < guestlist.Count; i++)
                    {                     
                        if (nameOfGuest == guestlist[i])
                        {
                            Console.WriteLine($"{nameOfGuest} is already in the list!");                                                    
                            isAlreadyInTheList = true;
                            break;
                        }
                        else
                        {
                            isAlreadyInTheList = false;
                            
                        }
                    }
                    if (!isAlreadyInTheList)
                    {
                        guestlist.Add(nameOfGuest);
                    }                   
                }                         
                else
                {                                 
                    for (int i = 0; i < guestlist.Count; i++)
                    {
                        if (nameOfGuest != guestlist[i])
                        {
                            isNotInTheList = true;

                        }
                        else if(nameOfGuest == guestlist[i])
                        {
                            isNotInTheList = false;
                        }                     
                    }
                    if (isNotInTheList)
                    {
                        Console.WriteLine($"{nameOfGuest} is not in the list!");
                    }
                    guestlist.Remove(nameOfGuest);
                }                          
            }
            for (int i = 0; i < guestlist.Count; i++)
            {
                Console.WriteLine(guestlist[i]);
            }
            
        }
    }
}