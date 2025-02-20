using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    class Car : IVehicle
    {
        public int GetSeatCapacity()
        {
            return 5;
        }

        public int GetTankCapacity()
        {
            return 60;
        }
    }
}
