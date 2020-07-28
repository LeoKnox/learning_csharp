using System;
using System.Collections.Generic;
using System.Text;

// showing namespacing and how to handle conflict, do not name Console.cs!
namespace Classroom
{
    class Console
    {
        static public string Ask(string question)
        {
            System.Console.Write(question); // System.Console is used here because this is Console.cs
            return System.Console.ReadLine();
        }

        static public string Ask(int question)
        {
            System.Console.Write(question); // System.Console is used here because this is Console.cs
            return System.Console.ReadLine();
        }

        static public int AskInt(string question)
        {
            try
            {
                System.Console.Write(question);
                return int.Parse(System.Console.ReadLine());
            }
            catch (Exception)
            {
                throw new FormatException("Input was not a number.");
            }
        }
    }
}