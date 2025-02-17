using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class OrdinaryFactory : VehicleFactory
    {
        public override Vehicle CreateFactory(string name)
        {
            return name switch
            {
                "Car1" => new OrdinaryCar1(),
                "Car2" => new OrdinaryCar2(),
                _ => throw new Exception("Invalid vehicle")
            };

        }
    }
}
