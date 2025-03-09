using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.cs
{
    class Ticket
    {
        DateTime time;
        int id;
        Vehicle vehicle;
        ParkingSpot parkingSpot;

        public Ticket()
        {
            this.time = new DateTime();
            this.id = Convert.ToInt32(Guid.NewGuid());
        }

        public Ticket GetTicket(Vehicle vehicle, ParkingSpot parkingSpot)
        {
            this.vehicle = vehicle;
            this.parkingSpot = parkingSpot;
            return this;
        }
    }
}
