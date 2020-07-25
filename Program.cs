using System;
using System.Collections.Generic;

namespace learning_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            while(true)
            {
                var newStudent = new Student();

                Console.Write("Student Name: ");
                newStudent.Name = (Console.ReadLine());
                Console.Write("Student Grade: ");
                newStudent.Grade = (int.Parse(Console.ReadLine()));
                Console.Write("Student email: ");
                newStudent.SetEmail(Console.ReadLine());
                students.Add(newStudent);

                Console.Write("Add another student? (y/n)");
                if (Console.ReadLine() != "y")
                {
                    break;
                }
            }

            foreach (var student in students)
            {
                Console.WriteLine("Student name: {0} Student Grade: {1}", student.Name, student.Grade);
            }
        }
    }

    class Student
    {
        public string Name;
        public int Grade;
        private string Email;

        public void SetEmail(string email)
        {
            Email = email;
        }
    }
}
