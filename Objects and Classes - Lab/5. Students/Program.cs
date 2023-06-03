using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;

namespace _5._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>();

            string names = Console.ReadLine();

            while (names != "end")
            {
                string[] data = names.Split();

                string firstName = data[0];
                string lastName = data[1];
                int age = int.Parse(data[2]);
                string hometown = data[3];

                Students student = new Students()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    Hometown = hometown,
                };

                students.Add(student);
                names = Console.ReadLine();
            }

            string cityInput = Console.ReadLine();

            //foreach (Students student in students)
            //{
            //    if (cityInput == student.Hometown)
            //    {
            //        Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            //    }
            //}

            List<Students> filteredNames = students.Where(s => s.Hometown == cityInput).ToList();

            foreach (Students student in filteredNames)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }




        }
    }
}
