using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutStratergyPattern
{
    class SportVehicle : Vehicle
    {
        public override void drive()
        {
            Console.WriteLine("Sport drive capability");
        }
    }
}
