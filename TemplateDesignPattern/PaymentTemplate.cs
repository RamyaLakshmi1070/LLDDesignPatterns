using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPattern
{
    abstract class PaymentTemplate
    {
        public abstract void ValidateRequest();
        public abstract void DebitAmoount();
        public abstract void PlatformFee();
        public abstract void CreditAmount();

        public void Steps()
        {
            ValidateRequest();
            DebitAmoount();
            PlatformFee();
            CreditAmount();
        }
    }
}
