using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_Bai2
{
    class CashPayment : PaymentMethod
    {
        public CashPayment(bool displaymessage = true) : base("Cash", displaymessage)
        {
        }

        public override void Login()
        {
            DisplayMethod();
            Console.WriteLine("Login with Cash.");
        }

        public override void Payment()
        {
            Console.WriteLine("Processing payment with Cash.");
        }
    }
}
