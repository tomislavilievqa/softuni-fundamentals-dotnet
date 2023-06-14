using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
namespace _4._Students
{
    public class Students
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public double Grade { get; set; }
        public Students(string firstName, string secondName, double grade)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Grade = grade;
        }
        public override string ToString()
        {
            string result = ($"{FirstName} {SecondName}: {Grade:F2}");

            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var countOfStudents = int.Parse(Console.ReadLine());
            List<Students> studentsList = new List<Students>();

            for (int i = 0; i < countOfStudents; i++)
            {
                string[] input = Console.ReadLine().Split((" "), StringSplitOptions.RemoveEmptyEntries).ToArray();

                string firstName = input[0];
                string secondName = input[1];
                float grade = float.Parse(input[2]);

                Students student = new Students(firstName, secondName, grade);

                studentsList.Add(student);
            }

            List<Students> filteredStudents = studentsList.OrderByDescending(x => x.Grade).ToList();

            foreach (Students students in filteredStudents)
            {
                Console.WriteLine(students);

            }
        }
    }
}