using System;

namespace learning_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of students:");
            var studentCount = int.Parse(Console.ReadLine());

            var studentNames = new string[studentCount];
            var studentGrades = new string[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write("Student Name: ");
                studentNames[i] = Console.ReadLine();
                Console.Write("Student Grade: ");
                studentGrades[i] = Console.ReadLine();
            }
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Student name: {0} Student Grade: {1}", studentNames[i], studentGrades[i]);
            }
        }
    }
}
