using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithStratergyPattern
{
    class PassengerVehicle : Vehicle
    {
        public PassengerVehicle():base(new NormalDrive())
        {
              
        }
    }
}
