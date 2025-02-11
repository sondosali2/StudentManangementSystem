using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    internal class Student
    {
        public Student(int id = 0, string name = "none", List<string> courses=null)
        {
            Id = id;
            Name = name;
            this.courses = courses;
        }

        public int Id { get; set; }
        public string Name { get; set; }
       public List<string> courses { get; set; }

        public void Display()
        {
            Console.WriteLine( $"Id :{Id}, Name :{Name}, ");
            Console.WriteLine("list " );
         
            foreach (var item in courses)
            {
                Console.WriteLine( item );
            }
        }
        
    }
}
