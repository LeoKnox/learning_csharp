using System;

namespace learning_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Name: ");
            string a = Console.ReadLine();
            if (a == "")
            {
                a = TryAgain(a);
            }
            Console.Write("Enter Age: ");
            string b = Console.ReadLine();
            if (b == "")
            {
                b = TryAgain(b);
            }
            Console.Write("Enter your birth month: ");
            string c = Console.ReadLine();
            if (c == "")
            {
                c = TryAgain(c);
            }
            Console.WriteLine("Your name is  {0}", a);
            Console.WriteLine("Your age is {0}",b);
            Console.WriteLine("Your birth month is {0}", c);

            if(c == "march")
            {
                Console.WriteLine("You are an Aries.");
            }
            else if(c == "april")
                {
                Console.WriteLine("You are a Taurus");
            }
            else if(c == "may")
            {
                Console.WriteLine("You are a Gemini");
            }
        }
        static string TryAgain(string x)
        {
            do
            {
                Console.Write("You didn't type anything try again:");
                x = Console.ReadLine();
            } while (x == "");
            return (x);
        }
    }
}
