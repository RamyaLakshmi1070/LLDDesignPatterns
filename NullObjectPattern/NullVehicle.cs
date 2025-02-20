using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    class NullVehicle : IVehicle
    {
        public int GetSeatCapacity()
        {
            return 0;
        }

        public int GetTankCapacity()
        {
            return 0;
        }
    }
}
