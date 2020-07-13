using System;

namespace learning_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Name: ");
            string a = Console.ReadLine();
            Console.Write("Enter Age: ");
            string b = Console.ReadLine();
            Console.Write("Enter favorite color: ");
            string c = Console.ReadLine();
            Console.WriteLine("Your name is  {0}", a);
            Console.WriteLine("Your age is {0}",b);
            Console.WriteLine("Your favorite coloe is {0}", c);
        }
    }
}
