using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern2
{
    class SpriteHandler : VendingMachineHandler
    {
        public SpriteHandler(VendingMachineHandler vendingMachineHandler) : base(vendingMachineHandler)
        {
        }
        public override void Items(int items)
        {
            if (items == sprite)
            {
                Console.WriteLine("Here is your Sprite");
            }
            else
                base.Items(items);
        }
    }
}
