using System;

namespace classroom
{
    class Teacher : Member, IPayee
    {
        public int ClassSize;

        public void Pay()
        {
            Console.WriteLine("Paying Teacher");
        }
    }
}