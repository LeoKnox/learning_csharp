using System;
using System.Collections.Generic;

namespace learning_csharp
{
    enum School
    {
        hh,
        bh,
        ch
    }
    class Program
    {
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            Import();

            while(true)
            {
                try {
                    var newStudent = new Student();

                    newStudent.Name = Util.Console.Ask("Student Name: ");
                    newStudent.Grade = Util.Console.AskInt("Student Grade: ");
                    newStudent.School = (School) Util.Console.AskInt("School(type number\n  0: hh, 1: bh, 2 ch): ");
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
                catch (FormatException msg)
                {
                    Console.WriteLine(msg.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("Error adding student grade, try again");
                }
            }

            foreach (var student in students)
            {
                Console.WriteLine("Student name: {0} Student Grade: {1}", student.Name, student.Grade);
            }
            Exports();
        }

        static void Import()
        {
            var importedStudent = new Student("dasffasf", 534, "adasfdsaf"); // simulates imported data
        }

        static void Exports()
        {
            foreach (var student in students)
            {
                switch(student.School)
                {
                    case School.hh:
                        Console.WriteLine("Exporting to hh");
                        break;
                    case School.bh:
                        Console.WriteLine("Exporting to bh");
                        break;
                    case School.ch:
                        Console.WriteLine("Exporting to ch");
                        break;
                }
            }
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
        public School School;

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
