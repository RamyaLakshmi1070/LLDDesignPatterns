using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.cs
{
    class TwoWheelerParkingSpot : ParkingSpot
    {
        int price;
        public TwoWheelerParkingSpot()
        {
            price = 200;
        }
        public override int GetPrice()
        {
            return price;
        }
    }
}
