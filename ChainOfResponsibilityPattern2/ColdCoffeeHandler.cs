using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern2
{
    class ColdCoffeeHandler : VendingMachineHandler
    {
        public ColdCoffeeHandler(VendingMachineHandler vendingMachineHandler) : base(vendingMachineHandler)
        {
        }
        public override void Items(int items)
        {
            if (items == coldCoffee)
            {
                Console.WriteLine("Here is your Cold Coffee");
            }
            else
                base.Items(items);
        }
    }
}
