using System;
using System.Collections.Generic;

namespace StudentManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School school = new School();

            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add a new student");
                Console.WriteLine("2. Add a new course");
                Console.WriteLine("3. Enroll student in a course");
                Console.WriteLine("4. Display all students");
                Console.WriteLine("5. Display all courses");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent(school);
                        break;

                    case "2":
                        AddCourse(school);
                        break;

                    case "3":
                        EnrollStudentInCourse(school);
                        break;

                    case "4":
                        school.displayallstudents();
                        break;

                    case "5":
                        school.displaycourses();
                        break;

                    case "6":
                        Console.WriteLine("Exiting program...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }

        static void AddStudent(School school)
        {
            Console.Write("\nEnter Student ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            school.addnewstudent(new Student { Id = id, Name = name,courses = new List<string>() });
            Console.WriteLine($"Student {name} added successfully!");
        }

        static void AddCourse(School school)
        {
            Console.Write("\nEnter Course Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Instructor Name: ");
            string instructor = Console.ReadLine();

            school.addnewcourse(new Course { Name = name, Instructor = instructor });
            Console.WriteLine($"Course {name} added successfully!");
        }

        static void EnrollStudentInCourse(School school)
        {
            Console.Write("\nEnter Student ID: ");
            int studentId = int.Parse(Console.ReadLine());

            Console.Write("Enter Course Name: ");
            string courseName = Console.ReadLine();

            school.addstudentincourse(studentId, courseName);
        }
    }
}
