using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace _5._Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }

    }
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string names = Console.ReadLine();

            while (names != "end")
            {
                string[] data = names.Split();

                string firstName = data[0];
                string lastName = data[1];
                int age = int.Parse(data[2]);
                string hometown = data[3];

                if (isExisting(students, firstName, lastName))
                {
                    Student student = GetStudent(students, firstName, lastName);
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.Hometown = hometown;

                }
                else
                {
                    Student student = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        Hometown = hometown,
                    };
                    students.Add(student);

                }

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

            List<Student> filteredNames = students.Where(s => s.Hometown == cityInput).ToList();

            foreach (Student student in filteredNames)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }

        }

        static bool isExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
        static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;

        }
    }


}

