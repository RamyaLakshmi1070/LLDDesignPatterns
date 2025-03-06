using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPattern
{
    class PaymentToFriend : PaymentTemplate
    {
        public override void CreditAmount()
        {
            //Credit Amount Payment logic
            Console.WriteLine("Credited Amount successfully");
        }

        public override void DebitAmoount()
        {
            //Debit Amount Payment  logic
            Console.WriteLine("Debited Amount Successfully");
        }

        public override void PlatformFee()
        {
            Console.WriteLine("0% Platform Fees");
        }

        public override void ValidateRequest()
        {
            //Validate request logic
            Console.WriteLine("Request has been validated");
        }
    }
}
