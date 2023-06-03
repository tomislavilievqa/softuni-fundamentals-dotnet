using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._Students
{
    class Students
    {
        //public Students(string firstName,string lastName, int age, string hometown)
        //{
        //    this.FirstName = firstName;
        //    this.LastName = lastName;
        //    this.Age = age;
        //    this.Hometown = hometown;
        //}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }

        static bool isExisting(List<Students> students, string firstName, string lastName)
        {
            if (firstName == firstName && lastName == lastName)
            {
                return true;
            }
            
            return false;
        }
    }
}
