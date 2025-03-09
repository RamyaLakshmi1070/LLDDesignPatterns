using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.cs
{
    class FourWheelerParkingSpot : ParkingSpot
    {
        int price;
        public FourWheelerParkingSpot()
        {
            price = 400; 
        }

        public override int GetPrice()
        {
            return price;
        }
    }
}
