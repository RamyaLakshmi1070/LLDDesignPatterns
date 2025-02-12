using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithStratergyPattern
{
    class OffRoadVehicle : Vehicle
    {
        public OffRoadVehicle():base(new SpecialDrive())
        {
                
        }
    }
}
