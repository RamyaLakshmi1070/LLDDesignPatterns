using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutStratergyPattern
{
    class PassengerVehicle :Vehicle
    {
        public override void drive()
        {
            Console.WriteLine("Normal Drive capability");
        }

    }
}
