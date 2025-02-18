using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern2
{
    abstract class VendingMachineHandler
    {
        VendingMachineHandler nextHandler;
        public static int coke = 1;
        public static int coldCoffee = 2;
        public static int sprite = 3;
        protected VendingMachineHandler(VendingMachineHandler vendingMachineHandler)
        {
            nextHandler = vendingMachineHandler;
        }

        public virtual void Items(int items)
        {
            if (nextHandler != null)
                nextHandler.Items(items);
        }

    }
}
