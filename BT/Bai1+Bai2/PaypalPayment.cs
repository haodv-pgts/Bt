using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_Bai2
{
    class PaypalPayment : PaymentMethod
    {
        public PaypalPayment(bool displaymessage = true) : base("Paypal", displaymessage)
        {
        }

        public override void Login()
        {
            DisplayMethod();
            Console.WriteLine("Login with Paypal.");
        }

        public override void Payment()
        {
            Console.WriteLine("Processing payment with Paypal.");
        }
    }
}
