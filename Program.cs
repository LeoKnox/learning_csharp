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

                newStudent.Name = Util.Console.Ask("Student Name: ");
                newStudent.Grade = int.Parse(Util.Console.Ask("Student Grade: "));
                newStudent.email = Util.Console.Ask("Student Email: ");
                students.Add(newStudent);
                Student.Count++;
                Console.WriteLine("Number of Students: {0}", Student.Count);

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
        static public int Count = 0;

        public string Name;
        public int Grade;
        private string Email;

        public string email
        {
            set { Email = value; Console.WriteLine(Email); } // setter acts as function can add logic to it.
        }

        public void SetEmail(string email)
        {
            Email = email;
        }
    }
}
