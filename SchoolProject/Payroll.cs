using System;
using System.Collections.Generic;

namespace classroom
{
    interface IPayee
    {
        void Pay();
    }
    class PayRoll
    {
        Teacher teacher1 = new Teacher();
        Teacher teacher2 = new Teacher();
        Principal principal = new Principal();
        public void PayAll()
        {
            teacher1.Pay();
            teacher2.Pay();
            principal.Pay();
        }
    }
}