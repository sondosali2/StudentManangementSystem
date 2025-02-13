using StudentManagementSystem;

internal class School
{
    public List<Student> students;
    public List<Course> courses;

    public School(List<Student> students = null, List<Course> courses = null)
    {
        this.students = students ?? new List<Student>(); 
        this.courses = courses ?? new List<Course>();   
    }

    public void displayallstudents()
    {
        Console.WriteLine("\nAll Students:");
        foreach (var item in students)
        {
            item.Display();
        }
    }

    public void displaycourses()
    {
        Console.WriteLine("\nAll Courses:");
        foreach (var item in courses)
        {
            Console.WriteLine(item.DisplayDetails()); 
        }
    }

    public void addnewstudent(Student student)
    {
        students.Add(student);
        Console.WriteLine($"\nNew student '{student.Name}' added.");
    }

    public void addnewcourse(Course course)
    {
        courses.Add(course);
        Console.WriteLine($"\nNew course '{course.Name}' added.");
    }

    internal void addstudentincourse(int v1, string v2)
    {
        Student student = new Student();
        foreach (var item in students)
        {
            if (item.Id == v1)
            {
                student = item;
                break;
            }
        }
        student.courses.Add(v2);
    }
}
