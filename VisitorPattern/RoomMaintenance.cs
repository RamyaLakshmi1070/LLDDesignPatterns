using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class RoomMaintenance : IVisitor
    {
        public void visit(SingleRoom singleRoom)
        {
            Console.WriteLine("Performing Maintenance for Single Room");
        }

        public void visit(DoubleRoom doubleRoom)
        {
            Console.WriteLine("Performing Maintenance for Double Room");
        }

        public void visit(DeluxeRoom deluxeRoom)
        {
            Console.WriteLine("Performing Maintenance for Deluxe Room");
        }
    }
}
