using System.Collections.Generic;
using System;

namespace _10._SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //•	Add: { lessonTitle} – add the lesson to the end of the schedule, if it does not exist.
           //•	Insert: { lessonTitle}:{ index} – insert the lesson to the given index, if it does not exist.
           //•	Remove: { lessonTitle}  – remove the lesson, if it exists.
           //•	Swap: { lessonTitle}:{ lessonTitle} – swap the position of the two lessons, if they exist.


            List<string> initialLessonsList = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = "";
            
            List<string> command = Console.ReadLine()
                .Split(new[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while ((input = Console.ReadLine()) != "course start")
            {
                
                switch (command[0])
                {
                    case "Add":

                        break;
                    
                    case "Insert":

                        break;
                    
                    case "Remove":

                        break;
                    
                    case "Swap":

                        break;
                   
                }

            }

        }
    }
}