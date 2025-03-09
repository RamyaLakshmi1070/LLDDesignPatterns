using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.cs
{
    class TwoWheelerParkingManager : ParkingSpotManager
    {
        private List<ParkingSpot> parkingSpots;

        public TwoWheelerParkingManager():base(new List<ParkingSpot>())
        {
            parkingSpots.Add(new TwoWheelerParkingSpot());
            parkingSpots.Add(new TwoWheelerParkingSpot());
        }
    }
}
