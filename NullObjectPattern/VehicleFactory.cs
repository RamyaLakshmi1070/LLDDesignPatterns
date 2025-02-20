using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    class VehicleFactory
    {
        IVehicle vehicle;

        public IVehicle GetVehicle(String Vehicle)
        {
            switch(Vehicle)
            {
                case "Car":
                    return new Car();
                default:
                    return new NullVehicle();
            }
        }
    }
}
