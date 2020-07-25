using System;
using System.Collections.Generic;

namespace learning_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentNames = new List<string>();
            var studentGrades = new List<int>();

            while(true)
            {
                Console.Write("Student Name: ");
                studentNames.Add(Console.ReadLine());
                Console.Write("Student Grade: ");
                studentGrades.Add(int.Parse(Console.ReadLine()));

                Console.Write("Add another student? (y/n)");
                if (Console.ReadLine() != "y")
                {
                    break;
                }
            }
            for (int i = 0; i < studentNames.Count; i++)
            {
                Console.WriteLine("Student name: {0} Student Grade: {1}", studentNames[i], studentGrades[i]);
            }
        }
    }
}
