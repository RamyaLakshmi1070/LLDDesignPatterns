using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern2
{
    class CokeHandler : VendingMachineHandler
    {
        public CokeHandler(VendingMachineHandler vendingMachineHandler) : base(vendingMachineHandler)
        {
        }

        public override void Items(int items)
        {
            if (items == coke)
            {
                Console.WriteLine("Here is your Coke");
            }
            else
                base.Items(items);
        }
    }
}
