using System;

namespace learning_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentGrade = new int[] { 80, 77, 45, 87, 53, 43, 67, 24, 86, 98 };

            foreach (int i in studentGrade)
            {
                Console.WriteLine(i);
            }
        }
    }
}
