using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class LuxuryCarFactory : VehicleFactory
    {
        public override Vehicle CreateFactory(string name)
        {
            switch(name)
            {
                case "Car1": 
                    return new LuxuryCar1();
                case "Car2":
                    return new LuxuryCar2();
                default:
                    throw new Exception("Invalid");
            }
        }
    }
}
