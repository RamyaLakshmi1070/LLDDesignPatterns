using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutStratergyPattern
{
    class OffRoadVehicle:Vehicle
    {
        public override void drive()
        {
            Console.WriteLine("Sport Vehicle capibilty");
        }
    }
}
