using System;
using System.Collections.Generic;
using System.Text;

// showing namespacing and how to handle conflict, do not name Console.cs!
namespace Util
{
    class Console
    {
        static public string Ask(string question)
        {
            System.Console.Write(question); // System.Console is used here because this is Console.cs
            return System.Console.ReadLine();
        }
    }
}