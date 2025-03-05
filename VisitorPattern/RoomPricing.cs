using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class RoomPricing : IVisitor
    {
        public void visit(SingleRoom singleRoom)
        {
            singleRoom.roomPrice = 1000;
            Console.WriteLine("Computation logic for single room price");
        }

        public void visit(DoubleRoom doubleRoom)
        {
            doubleRoom.roomPrice = 1000;
            Console.WriteLine("Computation logic for single room price");
        }

        public void visit(DeluxeRoom deluxeRoom)
        {
            deluxeRoom.roomPrice = 1000;
            Console.WriteLine("Computation logic for single room price");
        }
    }
}
