using System;

namespace Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            var sq = new Square() { Width = 2};
            var tr = new Triangle() { Base = 2, Height = 5 };

            sq.Display();
            tr.Display();
        }
    }

    abstract class Shape
    {
        public abstract int GetArea();

        public void Display()
        {
            Console.WriteLine("The area is {0}", GetArea());
        }
    }
    class Square : Shape
    {
        public int Width;

        public override int GetArea()
        {
            return Width * Width;
        }
    }
    
    class Triangle : Shape
    {
        public int Base;
        
        public override int GetArea()
        {
            return (Base * Height) / 2;
        }
        public int Height;
    }
}
