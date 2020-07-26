using System;
using System.Collections.Generic;

namespace learning_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Import();
            var students = new List<Student>();

            while(true)
            {
                var newStudent = new Student();

                newStudent.Name = Util.Console.Ask("Student Name: ");
                var result = int.TryParse(Util.Console.Ask("Student Grade: "), out newStudent.Grade);
                while (!result)
                {
                    result = int.TryParse(Util.Console.Ask("Student Grade: "), out newStudent.Grade);
                }
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

        static void Import()
        {
            var importedStudent = new Student("dasffasf", 534, "adasfdsaf"); // simulates imported data
        }
    }

    class Member
    {
        public String Name;
        protected String Email; // Use protected instead of private for inheritance
    }

    class Student : Member
    {
        static public int Count = 0;

        public int Grade;

        public string email
        {
            set { Email = value; Console.WriteLine(Email); } // setter acts as function can add logic to it.
        }

        public Student()
        {
        }

        public Student(string name, int grade, string email)
        {
            Name = name;
            Grade = grade;
            Email = email;
        }
    }

    class Teacher : Member
    {
        public int ClassSize;
    }
}
