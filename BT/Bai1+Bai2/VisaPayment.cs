using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_Bai2
{
    class VisaPayment : PaymentMethod
    {
        public VisaPayment(bool displaymessage = true) : base("visa", displaymessage)
        {
        }

        public override void Login()
        {
            DisplayMethod();
            Console.WriteLine("Login payment with Visa.");
        }

        public override void Payment()
        {
            Console.WriteLine("Processing payment with Visa.");
        }
    
    }
}
