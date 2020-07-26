using System;

namespace outreference
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            Console.WriteLine(x);
            Five(out x);
            Console.WriteLine(x);
        }

        static void Five(out int a) // cannot overload out and ref though
        {
            a = 5;
            Console.WriteLine(a);
        }

        /*static void Five(ref int a)
        {
            a = 5;
            Console.WriteLine(a);
        }*/
        static void Five(int a) // you can overload function for reference and nonreference
        {
            a = 5;
            Console.WriteLine(a);
        }
    }
}
