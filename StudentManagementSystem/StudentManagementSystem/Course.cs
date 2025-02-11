using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    internal class Course
    {
        public Course(string name="none", string instructor="none")
        {
            Name = name;
            Instructor = instructor;
        }

        public string Name { get; set; }
        public string Instructor { get; set; }
        public string DisplayDetails()
        {
            return $"Name :{Name},Instructor: {Instructor} ";
        }

    }
}
