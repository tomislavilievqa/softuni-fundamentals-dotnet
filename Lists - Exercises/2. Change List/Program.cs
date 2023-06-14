using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().
                Split().
                Select(s => int.Parse(s)).
                ToList();
            
            string input;

            while((input=Console.ReadLine()) != "end")
            {
                string[] commands = input.Split().ToArray();


                switch(commands[0]) {

                    case "Delete":
                        for (int i = 0; i < list.Count; i++)
                        {
                            int numberToDelete = int.Parse(commands[1]);
                            if (numberToDelete == list[i])
                            {
                                list.RemoveAt(i);
                            }
                        }
                        break;

                    case "Insert":
                        int numberToInsert = int.Parse(commands[1]);
                        int position = int.Parse(commands[2]);
                        list.Insert(position,numberToInsert);
                        break;              
                }
            
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}