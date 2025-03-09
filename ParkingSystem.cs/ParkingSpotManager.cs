using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.cs
{
    abstract class ParkingSpotManager
    {
        List<ParkingSpot> parkingSpots;

        public ParkingSpotManager(List<ParkingSpot> parkingSpots)
        {
            this.parkingSpots = parkingSpots;
        }

        //protected abstract ParkingSpot FindParkingSpace();
        public void AddParkingSpace(ParkingSpot spot)
        {
            parkingSpots.Add(spot);
        }
        public void RemoveParkingSpace(ParkingSpot spot)
        {
            parkingSpots.Remove(spot);
        }
        public void ParkVehicle(Vehicle vehicle, ParkingSpot spot)
        {
            spot.ParkVehicle(vehicle);
        }
        public void RemoveVehicle(ParkingSpot spot)
        {
            spot.UnParkVehicle();
        }
    }
}
