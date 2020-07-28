using System;
using System.Collections.Generic;

namespace classroom
{
    class Principal : Member, IPayee
    {
        public void Pay()
        {
            Console.WriteLine("Paying Principal");
        }
    }
}