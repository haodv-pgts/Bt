using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_Bai2
{
    abstract class PaymentMethod
    {
        protected string method;
        protected bool displaymessage;

        protected PaymentMethod(string method, bool displaymessage = true)
        {
            this.displaymessage = displaymessage;
            this.method = method;
        }

        protected void DisplayMethod()
        {
            if (displaymessage)
            {
                Console.WriteLine($"Using payment method: {method}");
            }
        }
        public abstract void Login();
        public abstract void Payment();
    }
}
