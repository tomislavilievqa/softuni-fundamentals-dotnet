using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace _7._Order_by_Age
{
    public class People
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public People(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;

        }
        public override string ToString()
        {
            string result = ($"{Name} with ID: {Id} is {Age} years old.");

            return result;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<People> people = new List<People>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] data = input.Split((" "), StringSplitOptions.RemoveEmptyEntries).ToArray();

                string name = data[0];
                string id = data[1];
                int age = int.Parse(data[2]);

                People person = new People(name,id,age);

                people.Add(person);
            }

            people = people.OrderBy(x => x.Age).ToList();

            Console.WriteLine(String.Join(Environment.NewLine,people));
        }

    }
}