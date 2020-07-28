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
        List<IPayee> payees = new List<IPayee>();
        public PayRoll()
        {
            payees.Add( new Teacher());
            payees.Add(new Teacher());
            payees.Add(new Principal());
        }
        public void PayAll()
        {
            foreach (var payee in payees)
            {
                payee.Pay();
            }
        }
    }
}