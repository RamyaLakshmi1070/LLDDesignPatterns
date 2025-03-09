using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.cs
{
    class FourWheelerParkingManager : ParkingSpotManager
    {
        List<ParkingSpot> parkingSpots;
        public FourWheelerParkingManager() : base(new List<ParkingSpot>())
        {
            parkingSpots.Add(new FourWheelerParkingSpot());
            parkingSpots.Add(new FourWheelerParkingSpot());
            parkingSpots.Add(new FourWheelerParkingSpot());
        }
    }
}
