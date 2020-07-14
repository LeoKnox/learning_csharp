using System;

namespace learning_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter username: ");
            string u = Console.ReadLine();
            Console.Write("Enter Passcode: ");
            string p = Console.ReadLine();
            if (p == "secret")
            {
                Console.WriteLine("User {0} has been authenticade.", u);
            }
            else
            {
                Console.WriteLine("User {0} cannot be Authenticated.", u);
            }
        }
    }
}
