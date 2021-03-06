﻿using System;
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
        Logger.Log("Tracker started", "SchoolTracer");
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            Import();

            var someObject = new { name = "ddd", num=44 }; // anonymous type, no object name but is object

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

            ShowGrade("");

            foreach (var student in students)
            {
                Console.WriteLine("Student name: {0} Student Grade: {1}", student.Name, student.Grade);
            }
            Exports();

            students = null; // sets object to empty for garbage collection does not work for int does with string
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

        static void ShowGrade(string name)
        {
            var found = students.Find(student => student.Name == name);
            Console.WriteLine("{0}'s Grade: {1}", found.Name, found.Grade);
        }

        static bool predicate(Student student) // converted into lambda expression above
        {
            return (student.Name == "Jim");
        }
    }

    class Member
    {
        public string Name { get; set; }
        public string Email { get; set; }
        //protected String Email; // Use protected instead of private for inheritance
    }

    class Student : Member
    {
        static public int Count { get; set; }= 0;

        public int Grade { get; set; }
        public School School { get; set; }

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
        public int ClassSize { get; set; }
    }
}
